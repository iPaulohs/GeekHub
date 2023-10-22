using Microsoft.AspNetCore.Mvc;

namespace GeekHub.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
