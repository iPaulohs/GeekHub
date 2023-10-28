using GeekHub.Domains;
using GeekHub.DTO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [Route("/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
           _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public ActionResult<string> Get() => Ok($"API Response: Operating. \nDate: {DateTime.Now.ToShortDateString()}\nHour: {DateTime.Now.ToShortTimeString()}");

        [HttpPost]
        public async Task<ActionResult> RegisterUser([FromBody] UserDTO model)
        {
            var userIdDTO = $"<<{model.Username}>>@<<{new Guid(Guid.NewGuid().ToString())}>>";

            User user = new()
            {
                Id = userIdDTO,
                UserName = model.Username,
                Email = model.Email,
                EmailConfirmed = true,
                FavoriteMovies = new FavoritesListMovies()
                {
                    ListId = $"<<FAVORITES_LIST_ID>>@[{new Guid(Guid.NewGuid().ToString())}]>>",
                    Movies = new List<Movie>(),
                    ListName = $"FAVORITES_LIST_NAME::[{userIdDTO}]",
                },
                GeneralListMovies = new List<GeneralListMovies>(),
                BirthDate = model.BirthDate
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return BadRequest(result.Errors);
            }

            await _signInManager.SignInAsync(user, false);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromBody] UserDTO userInfo)
        {
            var result = await _signInManager.PasswordSignInAsync(userInfo.Email, userInfo.Password, isPersistent: false, lockoutOnFailure: false);

            if (result.Succeeded)
            {
                Ok();
            }

            ModelState.AddModelError(string.Empty, "Invalid Login.");
            return BadRequest(ModelState);
        }

    }
}
