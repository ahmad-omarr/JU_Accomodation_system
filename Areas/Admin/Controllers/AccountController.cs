using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Areas.Admin.ViewModels;
using SystemWebDorms.ViewModels;

namespace SystemWebDorms.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class AccountController : Controller
    {
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }



        public AccountController(UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager)
        {
            UserManager = _userManager;
            SignInManager = _signInManager;
        }

        public ActionResult Index()
        {
            var users = UserManager.Users.Select(c => new
            MVAccounts()
            {
                email = c.Email,
                username = c.UserName,
                
                PassWord = c.PasswordHash,
                //user_image = c.User_image,
                id = c.Id
            }).ToList();

            return View(users);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var user = new IdentityUser
                    {
                        Email = collection.Email,
                        UserName = collection.Email,

                        //UserName = collection.FullName,
                    };

                    var Result = await UserManager.CreateAsync(user, collection.Password);
                    if (Result.Succeeded)
                    {
                        await SignInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction(nameof(Login), "Account");

                    }
                    else
                    {
                        ModelState.AddModelError("", "Email Or Password not Correct");
                        return View(collection);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email Or Password not Correct");
                    return View(collection);
                }
            }
            catch
            {
                return View(collection);
            }
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    var result = await SignInManager.PasswordSignInAsync(collection.Email, collection.Password, isPersistent: collection.RememberMe, false);


                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Index), "MasterDorm");

                    }
                    else
                    {
                        ModelState.AddModelError("", "Email Or Password not Correct");
                        return View(collection);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email Or Password not Correct");
                    return View(collection);
                }
            }
            catch
            {
                return View(collection);
            }
        }




        public async Task<ActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}
