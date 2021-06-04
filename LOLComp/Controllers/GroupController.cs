using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LOGIC.Collections;
using LOGIC.Models;
using LOLComp.ModelConverters;
using LOLComp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    public class GroupController : Controller
    {
        private readonly GroupCollection groupCollection;
        private readonly UserCollection userCollection;
        private readonly SummonerCollection summonerCollection;

        public GroupController()
        {
            groupCollection = new GroupCollection();
            userCollection = new UserCollection();
            summonerCollection = new SummonerCollection();
        }
        public IActionResult Index()
        {
            try
            {
                var groupViewModelList = new List<GroupViewModel>();
                var userID = userCollection.GetUserByEmail(User.FindFirstValue(ClaimTypes.Email)).UserID;
                var groupModels = groupCollection.GetGroupsWithUserID(userID);
                foreach (var group in groupModels)
                {
                    var GroupViewModel = new GroupViewModel()
                    {
                        GroupName = group.Name
                    };
                    groupViewModelList.Add(GroupViewModel);
                }
                return View(groupViewModelList);
            }
            catch (Exception ex)
            {
                TempData["NoConnectionToDB"] = ex.Message;
                return RedirectToAction("Logout", "User");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateGroupViewModel createGroupViewModel)
        {
            if (ModelState.IsValid)
            {
                var currentUser = userCollection.GetUserByEmail(User.FindFirstValue(ClaimTypes.Email));
                try
                {
                    var summonerAccountID = (await summonerCollection.FindSummonerByNameAndRegion(createGroupViewModel.SummonerName, createGroupViewModel.Region)).AccountID;
                    groupCollection.CreateGroup(CreateGroupViewModel.ConvertViewModelToModel(createGroupViewModel, summonerAccountID, currentUser.Email), currentUser);
                }catch(Exception ex)
                {
                    TempData["RequesterError"] = ex.Message;
                    return View();
                }
            }
            return RedirectToAction("Index", "Group");
        }
    }
}
