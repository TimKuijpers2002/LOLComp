using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebAPIController : ControllerBase
    {
        public string Get()
        {
            return "Welcome To Web API";
        }
        public List<string> Get(int Id)
        {
            return new List<string> {
                "Data1",
                "Data2"
            };
        }
    }
}
