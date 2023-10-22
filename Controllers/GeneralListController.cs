using GeekHub.Commom;
using GeekHub.Database;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [Controller]
    [Route("/general")]
    public class GeneralListController
    {
        private readonly ICommomList _commomList;

        public GeneralListController(ICommomList commomList, GeekHubDBContext dBContext)
        {
            _commomList = commomList;
        }
    }
}
