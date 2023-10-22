using GeekHub.Commom;
using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    [Controller]
    [Route("/favorites")]
    public class FavoritesListController : ControllerBase
    {
        private readonly ICommomList _favoritesListRepository;

        public FavoritesListController(ICommomList favoritesListRepository)
        {
            _favoritesListRepository = favoritesListRepository;
        }
    }
}
