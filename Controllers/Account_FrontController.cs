using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.ViewModels;

namespace SystemWebDorms.Controllers
{
    public class Account_FrontController : Controller
    {
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }



        public Account_FrontController(UserManager<IdentityUser> _userManager, SignInManager<IdentityUser> _signInManager)
        {
            UserManager = _userManager;
            SignInManager = _signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(VM_Register_Front collection)
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
                        return RedirectToAction(nameof(Login));

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
        public async Task<ActionResult> Login(VM_Login_Front collection)
        {
            try
            {
                if (ModelState.IsValid)
                {


                    var result = await SignInManager.PasswordSignInAsync(collection.Email, collection.Password, isPersistent: collection.RememberMe, false);


                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(Index),"Home");

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
