using GeekHub.Services;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [Controller]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        private readonly HomeServices _homeServices;
        private readonly IConfiguration _configuration;

        public HomeController(HomeServices homeServices, IConfiguration configuration) 
        {
            _homeServices = homeServices;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var result = await _homeServices.HomeGet("https://api.themoviedb.org/3/trending/movie/day?language=pt-BR", _configuration["Api:ApiKey"]);

            if (result == null)
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
