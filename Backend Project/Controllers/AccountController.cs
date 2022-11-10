using Backend_Project.Models;
using Backend_Project.ViewModels.AccountVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(registerVM);
            }

            AppUser appUser = new AppUser
            {
                Fullname = registerVM.Fullname,
                Email = registerVM.Email,
            };

            IdentityResult result = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);
            }

            //await _signInManager.SignInAsync(appUser, false);

            return RedirectToAction(nameof(Login));

        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);

            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.EmailOrUsername);
            if (appUser is null)
            {
                appUser = await _userManager.FindByNameAsync(loginVM.EmailOrUsername);
            }

            if (appUser is null)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginVM);
            }

            var result = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginVM);
            }


            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }


}