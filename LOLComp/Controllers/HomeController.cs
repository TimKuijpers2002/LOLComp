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
using Microsoft.AspNetCore.Authorization;

namespace LOLComp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly LOGICAndViewModelConverter converter;
        private readonly UserCollection userCollection;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
            converter = new LOGICAndViewModelConverter();
            userCollection = new UserCollection();
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User.IsInRole("User"))
            {
                return RedirectToAction("Index", "LOL");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
