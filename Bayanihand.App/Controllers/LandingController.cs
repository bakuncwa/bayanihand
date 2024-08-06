using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
