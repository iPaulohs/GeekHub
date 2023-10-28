using GeekHub.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [Controller]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private readonly HomeServices _homeServices;

        public HomeController(HomeServices homeServices) 
        {
            _homeServices = homeServices;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var result = await _homeServices.HomeGet("https://api.themoviedb.org/3/trending/movie/day?language=pt-BR");

            if(result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
