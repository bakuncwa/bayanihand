using AutoMapper;
using Bayanihand.App.Models;
using Bayanihand.App.Models.Repositories;
using Bayanihand.DataModel;
using Microsoft.AspNetCore.Mvc;

namespace Bayanihand.App.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext dbc;
        private readonly IMapper mapper;
        private readonly IForumRepo repoForum;
        private readonly ISchedRepo repoSched;
        private readonly IPaymentRepo repoPay;

        public CustomerController(AppDbContext dbc, IMapper mapper, IForumRepo repoForum, ISchedRepo repoSched, IPaymentRepo repoPay)
        {
            this.dbc = dbc;
            this.mapper = mapper;
            this.repoForum = repoForum;
            this.repoSched = repoSched;
            this.repoPay = repoPay;
        }
        public async Task<IActionResult> Forum()
        {
            //populating data for checking
            var forumData = new ForumVM
            {
                DatePosted = DateTime.Now,
                Title = "Plumbing",
                Description = "Broken Faucet",
                Status = "Open"
            };

            var forumList = new List<ForumVM> { forumData }; 
            //return View(mapper.Map<List<ForumVM>>(await repo.GetAllAsync()));
            return View(forumList);
        }

        public IActionResult AddForum()
        {
            return View(new ForumVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddForum(ForumVM model)
        {
            //try
            //{
                if (ModelState.IsValid)
                {
                    model.DatePosted = DateTime.Now;
                    model.Status = "Open";
                
                    await repoForum.AddAsync(mapper.Map<ForumINV>(model));

                    return RedirectToAction("Forum");
                }
                else
                {
                    return View(model);
                }
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError("Error", ex.Message);
            //    return View(model);
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteForum(int Id)
        {
            ForumINV? f = await repoForum.GetAsync(Id);

            if (f != null)
            {
                await repoForum.DeleteAsync(Id);
            }

            return RedirectToAction("Forum");
        }

        public async Task<IActionResult> EditForum(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("Forum");
            }

            ForumINV? f = await repoForum.GetAsync(Id);

            if (f == null)
            {
                return RedirectToAction("Forum");
            }

            return View(mapper.Map<ForumVM>(f));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditForum(ForumVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await repoForum.UpdateAsync(mapper.Map<ForumINV>(model));

                    return RedirectToAction("Forum");
                }
                else
                {
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(model);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Applicants()
        {
            //populating data for checking
            var applicant = new ApplicationINV
            {
                ApplicationID = 1,
                DateApplied = DateTime.Now,
                hasApplied = true,
                ForumPostID = 1,
                HandymanID = 1,
            };
            var applicantsList = new List<ApplicationINV> { applicant };

            return View(applicantsList);
        }

        public IActionResult FollowUp()
        {
            return View();
        }

        public IActionResult JobSchedule()
        {
            //populating data for checking
            var schedData = new ScheduleVM
            {
                ScheduleName = "Plumbing D:",
                DateBooked = new DateTime(2024, 8, 12),
                StartTime = new DateTime(2024, 8, 12, 14, 12, 02),
                Status = "Checked In"
            };

            var schedList = new List<ScheduleVM> { schedData };
            //return View(mapper.Map<List<ForumVM>>(await repo.GetAllAsync()));
            return View(schedList);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckIn(int ScheduleID)
        {
            //ScheduleINV data = await repoSched.GetAsync(ScheduleID);
            
            ScheduleVM model = new();
            
            model.Status = "Checked In";

            return RedirectToAction("JobSchedule", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Void(int ScheduleId)
        {
            ScheduleVM model = new();

            model.Status = "Void";

            return RedirectToAction("JobSchedule", model);
        }

        public IActionResult Payment()
        {
            return View(new PaymentVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Payment(PaymentVM model)
        {
            model.DatePaid = DateTime.Now;
            model.hasPaid = true;

            if (ModelState.IsValid)
            {
                await repoPay.AddAsync(mapper.Map<PaymentProofINV>(model));

                return View();
            }
            else
            {
                return View(model);
            }
        }
    }
}
