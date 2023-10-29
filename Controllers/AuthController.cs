using GeekHub.Domains;
using GeekHub.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace GeekHub.Controllers
{
    [Route("/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
           _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public ActionResult<string> Get() => Ok($"API Response: Operating. \nDate: {DateTime.Now.ToShortDateString()}\nHour: {DateTime.Now.ToShortTimeString()}");

        [HttpPost("register")]
        public async Task<ActionResult> RegisterUser([FromBody] UserDTORegister model)
        {
            var userIdDTO = $"<<{model.UserName}>>@<<{new Guid(Guid.NewGuid().ToString())}>>";

            User user = new()
            {
                Id = userIdDTO,
                Name = model.Name,
                UserName = model.UserName,
                Email = model.Email,
                EmailConfirmed = true,
                BirthDate = model.BirthDate.Date,
                CPF = model.CPF,
                Password = model.Password
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            await _userManager.SetLockoutEnabledAsync(user, false);
            return Ok("Registered user!");
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserDTOLogin userInfo)
        {
            var user = await _userManager.FindByEmailAsync(userInfo.Email);

            if (user == null)
            {
                return BadRequest("User not found.");
            }
            else
            {
                Console.WriteLine("Usuário encontrado.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, userInfo.Password, lockoutOnFailure: false, isPersistent: false);

            if (result.Succeeded)
            {
                return Ok("Login sucessfull.");
            }
            else
            {
                return BadRequest("Login failed.");
            }
        }
    }
}
