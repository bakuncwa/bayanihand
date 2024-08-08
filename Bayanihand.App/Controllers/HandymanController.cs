using AutoMapper;
using Bayanihand.App.Models;
using Bayanihand.DataModel;
using Bayanihand.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Bayanihand.App.Controllers
{
    public class HandymanController : Controller
    {
        private readonly AppDbContext _dbcontext;
        private readonly IMapper _mapper;
        private readonly IHandymanRepository _repo;
        public HandymanController(AppDbContext _dbcontext, IMapper _mapper, IHandymanRepository _repo)
        {
            this._dbcontext = _dbcontext;
            this._mapper = _mapper;
            this._repo = _repo;
        }

        [Authorize(Roles = "Handyman")]
        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> ViewProfile()
        {
            var HandymanINV = await _repo.GetAllAsync();
            return View(_mapper.Map<List<HandymanProfileVM>>(HandymanINV));
        }


        //public async Task<HandymanINV?> GetProfileByUserIdAsync(string userId)
        //{
        //    return await _mapper.HandymanINV
        //        .FirstOrDefaultAsync(h => h.UserId == userId);
        //}

    }
}
