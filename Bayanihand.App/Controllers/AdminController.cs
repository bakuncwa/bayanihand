using Bayanihand.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Customer()
        {
            //populating data for checking
            var customerINQ = new InquiryINV
            {
                DateInquired = DateTime.Now,
                Title = "Bad Handyman",
                Description = "Construction Worker",
            };
            var customerList = new List<InquiryINV> { customerINQ };

            return View(customerList);
        }

        public IActionResult Handyman()
        {
            //populating data for checking
            var handymanINQ = new InquiryINV
            {
                DateInquired = DateTime.Now,
                Title = "Bad Customer",
                Description = "Construction Worker",
            };
            var handymanList = new List<InquiryINV> { handymanINQ };

            return View(handymanList);
        }

    }
}
