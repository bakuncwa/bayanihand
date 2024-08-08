using Bayanihand.App.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace Bayanihand.App.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult HandymanRegister()
        {
            return View(new HandymanRegisterVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HandymanRegister(HandymanRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                await RegisterUserAsync(model.Email, model.Password, "Handyman");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult CustomerRegister()
        {
            return View(new CustomerRegisterVM());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CustomerRegister(CustomerRegisterVM model)
        {
            if (ModelState.IsValid)
            {
                await RegisterUserAsync(model.Email, model.Password, "Customer");
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(model);
            }
        }

        public async Task RegisterUserAsync(string email, string password, string role)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                user = new IdentityUser { UserName = email, Email = email };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    if (!await roleManager.RoleExistsAsync(role))
                    {
                        await roleManager.CreateAsync(new IdentityRole(role));
                    }
                    await userManager.AddToRoleAsync(user, role);
                }
                else
                {
                    ModelState.AddModelError("Error", "Invalid Credentials");
                }
            }

        }

        [HttpGet]
        public IActionResult Login(string? returnUrl)
        {
            LoginVM loginVM = new();
            if (!string.IsNullOrEmpty(returnUrl))
                loginVM.ReturnUrl = returnUrl;
            return View(loginVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model, string? returnUrl)
        {
            IdentityUser? user = await userManager.FindByNameAsync(model.Username);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                        return LocalRedirect(returnUrl);
                    else
                        return LocalRedirect("/Handyman/Profile");
                }
                else
                {
                    ModelState.AddModelError("Error", "Invalid Credentials");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Invalid credentials");
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public new async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

    }
}
