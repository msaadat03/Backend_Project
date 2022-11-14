using Backend_Project.Interfaces;
using Backend_Project.Models;
using Backend_Project.Services.Interfaces;
using Backend_Project.ViewModels.AccountVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backend_Project.Controllers
{
        public class AccountController : Controller
        {
            private readonly UserManager<AppUser> _userManager;
            private readonly SignInManager<AppUser> _signInManager;
            private readonly IEmailService _emailService;
            private readonly IFileService _fileService;

            public AccountController(UserManager<AppUser> userManager,
                SignInManager<AppUser> signInManager,
                IEmailService emailService,
                IFileService fileService)
            {
                _userManager = userManager;
                _signInManager = signInManager;
                _emailService = emailService;
                _fileService = fileService;
            }

            [HttpGet]
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Register(RegisterVM registerVM)
            {
                if (!ModelState.IsValid)
                {
                    return View(registerVM);
                }

                AppUser user = new AppUser
                {
                    Fullname = registerVM.Fullname,
                    UserName = registerVM.Username,
                    Email = registerVM.Email
                };

                IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }

                    return View(registerVM);
                }

                string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

                string link = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token },
                    Request.Scheme, Request.Host.ToString());

                string path = "wwwroot/assets/templates/verify.html";
                string body = string.Empty;
                string subject = "Verify email";

                body = _fileService.ReadFile(path, body);

                body = body.Replace("{{link}}", link);
                body = body.Replace("{{fullname}}", user.Fullname);

                _emailService.Send(user.Email, subject, body, null);

                return RedirectToAction(nameof(VerifyEmail));
            }

            public async Task<IActionResult> ConfirmEmail(string userId, string token)
            {
                if (userId is null || token is null)
                {
                    return BadRequest();
                }

                AppUser user = await _userManager.FindByIdAsync(userId);

                if (user is null)
                {
                    return NotFound();
                }

                await _userManager.ConfirmEmailAsync(user, token);

                await _signInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }

            public IActionResult VerifyEmail()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Login(LoginVM loginVM)
            {
                if (!ModelState.IsValid)
                {
                    return View(loginVM);
                }

                AppUser user = await _userManager.FindByEmailAsync(loginVM.UsernameOrEmail);

                if (user is null)
                {
                    user = await _userManager.FindByNameAsync(loginVM.UsernameOrEmail);
                }

                if (user is null)
                {
                    ModelState.AddModelError("", "Email or password is wrong!");
                    return View(loginVM);
                }

                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);

                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Email or password is wrong!");
                    return View(loginVM);
                }

                return RedirectToAction("Index", "Home");
            }

            public async Task<IActionResult> Logout()
            {
                await _signInManager.SignOutAsync();

                return RedirectToAction("Index", "Home");
            }

            [HttpGet]
            public async Task<IActionResult> ForgetPassword()
            {
                return View();
            }

            public async Task<IActionResult> ForgetPassword(ForgetPasswordVM forgetPasswordVM)
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }

                AppUser existUser = await _userManager.FindByEmailAsync(forgetPasswordVM.Email);

                if (existUser is null)
                {
                    ModelState.AddModelError("Email", "User not found!");
                    return View();
                }

                string token = await _userManager.GeneratePasswordResetTokenAsync(existUser);

                string link = Url.Action(nameof(ResetPassword), "Account", new { userId = existUser.Id, token },
                    Request.Scheme, Request.Host.ToString());

                string path = "wwwroot/assets/templates/verify.html";
                string body = string.Empty;
                string subject = "Verify password reset email";

                body = _fileService.ReadFile(path, body);

                body = body.Replace("{{link}}", link);
                body = body.Replace("{{fullname}}", existUser.Fullname);

                _emailService.Send(existUser.Email, subject, body, null);

                return RedirectToAction(nameof(VerifyEmail));
            }

            [HttpGet]
            public IActionResult ResetPassword(string userId, string token)
            {
                return View(new ResetPasswordVM { Token = token, UserId = userId });
            }

            public async Task<IActionResult> ConfirmResetPassword(ResetPasswordVM resetPassword)
            {
                if (!ModelState.IsValid)
                {
                    return View(resetPassword);
                }

                AppUser existUser = await _userManager.FindByIdAsync(resetPassword.UserId);

                if (existUser is null)
                {
                    return NotFound();
                }

                await _userManager.ResetPasswordAsync(existUser, resetPassword.Token, resetPassword.Password);

                return RedirectToAction(nameof(Login));
            }
        }
    }
