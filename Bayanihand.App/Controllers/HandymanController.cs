using AutoMapper;
using Bayanihand.App.Models;
using Bayanihand.DataModel;
using Bayanihand.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Bayanihand.App.Controllers
{
    public class HandymanController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly IMapper _mapper;
        private readonly IHandymanRepository _repo;

        public HandymanController(AppDbContext dbcontext, IMapper mapper, IHandymanRepository repo)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<IActionResult> ViewProfile()
        {
            var handymanINV = await _repo.GetAllAsync();
            return View(_mapper.Map<List<HandymanProfileVM>>(handymanINV));
        }

        public async Task<IActionResult> Profile()
        {
            var handymanId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var handymanProfile = await _repo.GetProfileByUserIdAsync(handymanId);

            if (handymanProfile != null)
            {
                return RedirectToAction("/Customer/Forum");
            }
            else
            {
                return RedirectToAction("CreateProfile");
            }
        }

        [HttpGet]
        public IActionResult CreateProfile()
        {
            return View(new HandymanProfileVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProfile(HandymanProfileVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var handymanINV = _mapper.Map<HandymanINV>(model);
                    await _repo.AddAsync(handymanINV);

                    return RedirectToAction("Profile");
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

        [HttpGet]
        public async Task<IActionResult> EditProfile(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Profile");
            }

            var handymanINV = await _repo.GetAsync(id);
            if (handymanINV == null)
            {
                return RedirectToAction("Profile");
            }

            return View(_mapper.Map<HandymanProfileVM>(handymanINV));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(HandymanProfileVM model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var handymanINV = _mapper.Map<HandymanINV>(model);
                    await _repo.UpdateAsync(handymanINV);

                    return RedirectToAction("EditProfile");
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
    }
}