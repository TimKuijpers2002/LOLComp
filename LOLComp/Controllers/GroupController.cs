using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using LOGIC.Collections;
using LOLComp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    public class GroupController : Controller
    {
        private readonly GroupCollection groupCollection;
        private readonly UserCollection userCollection;

        public GroupController()
        {
            groupCollection = new GroupCollection();
            userCollection = new UserCollection();
        }
        public IActionResult Index()
        {
            var groupViewModelList = new List<GroupModel>();
            var userID = userCollection.GetUserByEmail(User.FindFirstValue(ClaimTypes.Email)).UserID;
            var groupModels = groupCollection.GetGroupsWithUserID(userID);
            foreach(var group in groupModels)
            {
                var GroupViewModel = new GroupModel()
                {
                    GroupName = group.Name
                };
                groupViewModelList.Add(GroupViewModel);
            }
            return View(groupViewModelList);
        }
    }
}
