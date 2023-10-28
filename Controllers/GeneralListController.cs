using GeekHub.Commom;
using GeekHub.Database;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [Controller]
    [Route("/general")]
    public class GeneralListController : ControllerBase
    {
        private readonly ICommomList _commomList;

        public GeneralListController(ICommomList commomList, GeekHubDBContext dBContext)
        {
            _commomList = commomList;
        }

        [HttpGet]
        public ActionResult<string> Teste()
        {
            _commomList.AddMovieOnList("123", 125, "teste", "<<teste>>");

            return NotFound();
        }
    }
}
