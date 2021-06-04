using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class CreateGroupViewModel
    {
        public string GroupName { get; set; }
        public string SummonerName { get; set; }
        public string Region { get; set; }

        public static Group ConvertViewModelToModel(CreateGroupViewModel viewmodel, string summonerAccountID, string userEmail)
        {
            var _model = new Group(0, viewmodel.GroupName, userEmail, summonerAccountID);
            return _model;
        }
    }
}
