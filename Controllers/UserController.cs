using GeekHub.Repository.User;
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

        [HttpGet]
        public IActionResult Get(string userId)
        {
            var result = _userRepository.GetAllMovies(userId);

            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddMovie(int movieId, string movieTitle, string userId)
        {
            _userRepository.AddMovie(movieId, movieTitle, userId);

            return Ok();
        }
    }
}
