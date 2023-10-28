using GeekHub.Repository.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [ApiController]
    [Route("/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [Authorize]
        [HttpGet]
        public ActionResult IsValidEmail(string email)
        {
            return Ok("Valid Email!");
        }
    }
}
