using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LOGIC.Collections;
using LOLComp.ModelConverters;
using LOLComp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    public class UserController : Controller
    {
        private readonly LOGICAndViewModel Converter;
        private readonly UserCollection userCollection;
        public UserController()
        {
            Converter = new LOGICAndViewModel();
            userCollection = new UserCollection();
        }
        public IActionResult Index()
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
        public async Task<IActionResult> Login([Bind] UserLoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                string LoginStatus = userCollection.ValidateLogin(UserLoginViewModel.ConvertViewModelToModel(user));

                if (LoginStatus == "Success")
                {
                    var all = userCollection.GetUsers();
                    var list = new List<UserModel>();
                    if (user.Email != null)
                    {
                        for (int i = 0; i < all.Count; i++)
                        {
                            if (user.Email == all[i].Email)
                            {
                                list.Add(new UserModel
                                {
                                    UserID = all[i].UserID,
                                    Name = all[i].Name,
                                    Email = all[i].Email,
                                    Password = all[i].Password,
                                    Role = all[i].Role
                                });

                                var claims = new List<Claim>
                                {
                                    new Claim(ClaimTypes.Email, user.Email),
                                    new Claim(ClaimTypes.Role, all[i].Role),
                                };
                                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                                await HttpContext.SignInAsync(principal);
                                TempData["LoggedIn"] = "You have logged in with your personal account.";
                                return RedirectToAction("Index", "LOL");

                            }
                        }
                    }
                }
                else
                {
                    TempData["UserLoginFailed"] = "Login Failed.Please enter correct credentials";
                    return View();
                }
            }
            return View();
        }
    }
}
