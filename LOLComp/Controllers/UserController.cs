using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LOGIC.Collections;
using LOGIC.Models;
using LOGIC.Validations;
using LOLComp.ModelConverters;
using LOLComp.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            var userModel = userCollection.GetUserByEmail(User.FindFirstValue(ClaimTypes.Email));
            var userViewModel = converter.ConvertToUserViewModel(userModel);
            return View(userViewModel);
        }

        [Authorize(Roles = "User")]
        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public IActionResult Update(UserViewModel viewModel)
        {
            var userToUpdate = userCollection.GetUserByEmail(User.FindFirstValue(ClaimTypes.Email));
            try
            {
                userToUpdate.UpdateUser(converter.ConvertToUser(viewModel, userToUpdate.Role), userToUpdate.UserID);
                return RedirectToAction("Logout", "User");
            }
            catch(Exception ex)
            {
                TempData["Updated"] = ex.Message;
                return View();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    userCollection.CreateUser(UserRegisterViewModel.ConvertViewModelToModel(viewModel));
                    TempData["Registrated"] = "You have succesfully registarted, you can now login!";
                    return RedirectToAction("Login");
                }
                catch(Exception ex)
                {
                    TempData["Registrated"] = ex.Message;
                    return View();
                }
            }
            return RedirectToAction("Index", "Home");      
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind] UserLoginViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string LoginStatus = userCollection.ValidateLogin(UserLoginViewModel.ConvertViewModelToModel(userViewModel));
                    if (LoginStatus == "Success")
                    {
                        var all = userCollection.GetUsers();
                        var list = new List<UserViewModel>();
                        if (userViewModel.Email != null)
                        {
                            for (int i = 0; i < all.Count; i++)
                            {
                                if (userViewModel.Email == all[i].Email)
                                {
                                    list.Add(converter.ConvertToUserViewModel(all[i]));

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
                catch (Exception ex)
                {
                    TempData["NoConnectionToDB"] = ex.Message;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [Authorize(Roles = "User")]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            TempData["UserLogout"] = "You have logged out!";
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
