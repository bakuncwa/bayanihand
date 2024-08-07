using Bayanihand.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Applicants()
        {
            //populating data for checking
            //var applicant = new ApplicationINV
            //{
            //    ApplicationID = 1,
            //    DateApplied = DateTime.Now,
            //    Title = "Fix Kitchen",
            //    CV = "Construction Worker",
            //    ForumPostID = 1,
            //    HandymanID = 1,
            //};
            //var applicantsList = new List<ApplicationINV> { applicant };

            return View(new List<ApplicationINV>());
        }
    }
}
