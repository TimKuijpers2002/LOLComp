using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly SummonerCollection summonerCollection;
        private readonly MatchCollection matchCollection;
        private readonly LOGICAndViewModelConverter converter;

        public LOLController(IMapper mapper)
        {
            _mapper = mapper;
            summonerCollection = new SummonerCollection();
            converter = new LOGICAndViewModelConverter();
            matchCollection = new MatchCollection(_mapper);
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
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(summonerViewModels);
        }

        [HttpGet]
        public async Task<IActionResult> Matches(SummonerViewModel summonerViewModel)
        {
            var matchViewModels = new List<MatchViewModel>();

            try
            {
                var matchList = await matchCollection.GetMatchHistory(summonerViewModel.Name, summonerViewModel.Region);
                foreach (var match in matchList)
                {
                    matchViewModels.Add(_mapper.Map<MatchViewModel>(match));
                }
            }
            catch (Exception ex)
            {
                TempData["IndexErrors"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }

            return View(matchViewModels);
        }

        public async Task<IActionResult> Profile(string summonerName, string region)
        {
            SummonerViewModel summonerViewModel = new SummonerViewModel();
            if (summonerName != null)
            {
                try
                {
                    var summoner = await summonerCollection.FindSummonerByNameAndRegion(summonerName, region);
                    var matches = await matchCollection.GetMatchHistory(summoner.AccountID, region);

                    summonerViewModel = converter.ConvertToSummonerViewModel(summoner);
                    foreach(var match in matches)
                    {
                        summonerViewModel.matchViewModels.Add(_mapper.Map<MatchViewModel>(match));
                    }
                }
                catch (Exception ex)
                {
                    TempData["IndexErrors"] = ex.Message;
                    return RedirectToAction("Index", "Home");
                }
            }

            return View(summonerViewModel);
        }
    }
}
