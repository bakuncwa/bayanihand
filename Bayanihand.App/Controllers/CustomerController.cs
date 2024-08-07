using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
