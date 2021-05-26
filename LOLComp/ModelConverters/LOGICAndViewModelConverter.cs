using LOGIC.Models;
using LOLComp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.ModelConverters
{
    public class LOGICAndViewModelConverter
    {
        private User user { get; set; }
        private UserViewModel userViewModel { get; set; }
        private Group group { get; set; }
        private GroupViewModel groupViewModel { get; set; }
        private SummonerViewModel summonerViewModel { get; set; }

        public User ConvertToUser(UserViewModel userViewModel, string role)
        {
            user = new User(userViewModel.UserID, userViewModel.Name, userViewModel.Email, userViewModel.Password, role);
            return user;
        }

        public UserViewModel ConvertToUserViewModel(User user)
        {
            userViewModel = new UserViewModel()
            {
                UserID = user.UserID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role
            };
            return userViewModel;
        }

        public Group ConvertToGroup(GroupViewModel groupViewModel)
        {
            group = new Group(groupViewModel.GroupID, groupViewModel.GroupName);
            return group;
        }

        public GroupViewModel ConvertToGroupViewModel(Group group)
        {
            groupViewModel = new GroupViewModel()
            {
                GroupID = group.GroupID,
                GroupName = group.Name
            };
            return groupViewModel;
        }

        public SummonerViewModel ConvertToSummonerViewModel(Summoner summoner)
        {
            summonerViewModel = new SummonerViewModel()
            {
                Name = summoner.Name,
                ProfileIconID = summoner.ProfileIconID,
                SummonerLevel = summoner.SummonerLevel,
                Region = summoner.Region
            };
            return summonerViewModel;
        }
    }
}
