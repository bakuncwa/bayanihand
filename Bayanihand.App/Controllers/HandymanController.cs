using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class HandymanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
