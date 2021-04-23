using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LOLComp.Models;
using System.Security.Claims;
using LOLComp.ModelConverters;
using LOGIC.Collections;
using Microsoft.AspNetCore.Authentication;

namespace LOLComp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LOGICAndViewModel Converter;
        private readonly UserCollection userCollection;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Converter = new LOGICAndViewModel();
            userCollection = new UserCollection();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
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
                    //If the ID isn't equil to Null-value, the if-statement is executed.
                    if (user.Email != null)
                    {
                        //Here it count with int 'i' and it keeps counting 'til the max value of all is counted.
                        for (int i = 0; i < all.Count; i++)
                        {
                            //When ID is equil to all; the program will 'copy' all values of Vehicleviewmodel and add it to VVM.
                            if (user.Email == all[i].Email)
                            {
                                list.Add(new UserModel
                                {
                                    UserID = all[i].UserID,
                                    Name = all[i].Name,
                                    Email = all[i].Email,
                                    Password = all[i].Password,
                                });

                                var claims = new List<Claim>
                                {
                                    new Claim(ClaimTypes.Email, user.Email),
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
