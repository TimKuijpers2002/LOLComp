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
        private readonly LOGICAndViewModelConverter converter;
        private readonly UserCollection userCollection;
        public UserController()
        {
            converter = new LOGICAndViewModelConverter();
            userCollection = new UserCollection();
        }
        public IActionResult Index()
        {
            var userModel = userCollection.GetUserByEmail(User.FindFirstValue(ClaimTypes.Email));
            var userViewModel = converter.ConvertToUserViewModel(userModel);
            return View(userViewModel);
        }

        public IActionResult Update(string email)
        {

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(UserRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                userCollection.CreateUser(UserRegisterViewModel.ConvertViewModelToModel(viewModel));
                TempData["Registrated"] = "You have succesfully registarted, you can now login!";
                return RedirectToAction("Login");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] UserLoginViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                string LoginStatus = userCollection.ValidateLogin(UserLoginViewModel.ConvertViewModelToModel(userViewModel));

                if (LoginStatus == "Success")
                {
                    var all = userCollection.GetUsers();
                    var list = new List<UserModel>();
                    if (userViewModel.Email != null)
                    {
                        for (int i = 0; i < all.Count; i++)
                        {
                            if (userViewModel.Email == all[i].Email)
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
                                    new Claim(ClaimTypes.Email, userViewModel.Email),
                                    new Claim(ClaimTypes.Role, all[i].Role),
                                };
                                ClaimsIdentity userIdentity = new ClaimsIdentity(claims, "login");
                                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                                await HttpContext.SignInAsync(principal);
                                TempData["LoggedIn"] = "You have logged in with your personal account.";
                                return RedirectToAction("Index", "Home");

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
