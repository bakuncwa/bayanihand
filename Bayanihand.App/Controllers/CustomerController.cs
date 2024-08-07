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
        private readonly IForumRepo repo;

        public CustomerController(AppDbContext dbc, IMapper mapper, IForumRepo repo)
        {
            this.dbc = dbc;
            this.mapper = mapper;
            this.repo = repo;
        }
        public async Task<IActionResult> Forum()
        {
            return View(mapper.Map<List<ForumVM>>(await repo.GetAllAsync()));
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
                
                    await repo.AddAsync(mapper.Map<ForumINV>(model));

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
            ForumINV? f = await repo.GetAsync(Id);

            if (f != null)
            {
                await repo.DeleteAsync(Id);
            }

            return RedirectToAction("Forum");
        }

        public async Task<IActionResult> EditForum(int? Id)
        {
            if (Id == null)
            {
                return RedirectToAction("Forum");
            }

            ForumINV? f = await repo.GetAsync(Id);

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
                    await repo.UpdateAsync(mapper.Map<ForumINV>(model));

                    return RedirectToAction("Forum");
                }
                else
                {
                    return View(model);
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View(model);
            }
        }
    }
}
