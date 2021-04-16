using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LOGIC.Collections;
using LOLComp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LOLComp.Controllers
{
    public class UserController : Controller
    {
        private GroupCollection groupCollection;

        private List<GroupModel> groupModels;

        public UserController()
        {
            groupCollection = new GroupCollection();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Groups(int userID)
        {
            //test purpose
            userID = 1
            groupModels = new List<GroupModel>();
            var Groups = groupCollection.GetGroupsWithUserID(userID);
            foreach(var group in Groups)
            {
                GroupModel groupModel = new GroupModel()
                {
                    GroupID = group.GroupID,
                    GroupName = group.Name,
                };
                groupModels.Add(groupModel);
            }
            return View(groupModels);
        }
    }
}
