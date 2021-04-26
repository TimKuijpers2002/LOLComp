using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    [Authorize(Roles = "User")]

    public class LOLController : Controller
    { 

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
