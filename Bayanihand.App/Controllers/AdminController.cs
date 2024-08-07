using AutoMapper;
using Bayanihand.App.Models.Repositories;
using Bayanihand.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext dbc;
        private readonly IMapper mapper;
        private readonly IForumRepo repo;
        private readonly IAdminRepo ADrepo;     

        public AdminController(AppDbContext dbc, IMapper mapper, IForumRepo repo, IAdminRepo ADRepo)    
        {
            this.dbc = dbc;
            this.mapper = mapper;
            this.repo = repo;
            this.ADrepo = ADRepo;
        }
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int Id)
        {
            InquiryINV? inq = await ADrepo.GetAsync(Id);

            if (inq != null)
            {
                await ADrepo.DeleteAsync(Id);
            }

            return RedirectToAction("Handyman");
        }

    }
}
