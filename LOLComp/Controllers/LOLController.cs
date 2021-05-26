using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOGIC.Collections;
using LOLComp.ModelConverters;
using LOLComp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    [Authorize(Roles = "User")]

    public class LOLController : Controller
    {
        private readonly SummonerCollection summonerCollection;
        private readonly LOGICAndViewModelConverter converter;

        public LOLController()
        {
            summonerCollection = new SummonerCollection();
            converter = new LOGICAndViewModelConverter();
        }

        [HttpGet]
        public async Task<IActionResult> Index(string summonerName)
        {
            var summonerViewModels = new List<SummonerViewModel>();

            if(summonerName != null)
            {
                try
                {
                    var summoners = await summonerCollection.FindSummonerByName(summonerName);
                    foreach(var summoner in summoners)
                    {
                        summonerViewModels.Add(converter.ConvertToSummonerViewModel(summoner));
                    }
                }
                catch (Exception ex)
                {
                    TempData["IndexErrors"] = ex.Message;
                }
            }

            return View(summonerViewModels);
        }
    }
}
