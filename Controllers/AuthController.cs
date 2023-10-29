using GeekHub.Domains;
using GeekHub.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GeekHub.Controllers
{
    [Route("/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IConfiguration _configuration;

        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
           _signInManager = signInManager;
            _userManager = userManager;
            _configuration = configuration;

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
            return Ok(GenerateToken(user));
        }

        private UserToken GenerateToken(User user)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, user.Email),
                new Claim("<<_GeekHub_>>", "<<_GHT_>>"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expirationToken = DateTime.UtcNow.AddHours(double.Parse(_configuration["TokenConfiguration:ExpireHour"]));

            JwtSecurityToken token = new(issuer: _configuration["TokenConfiguration:Issuer"], audience: _configuration["TokenConfiguration:Audience"], claims: claims, expires: expirationToken, signingCredentials: credentials);

            Console.WriteLine(token);

            return new UserToken()
            {
                Authenticated = true,
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expirationToken,
                Message = "Generate token sucessfull.",
                UserId = user.Id,
                UserName = user.UserName
            };
        
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
                return Ok(GenerateToken(user));
            }
            else
            {
                return BadRequest("Login failed.");
            }
        }
    }
}
