using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    public class LOLController : Controller
    {
        [Authorize(Roles = "User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
