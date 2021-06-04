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
        private User User { get; set; }
        private UserViewModel UserViewModel { get; set; }
        private Group Group { get; set; }
        private GroupViewModel GroupViewModel { get; set; }
        private SummonerViewModel SummonerViewModel { get; set; }
        private MatchViewModel MatchViewModel { get; set; }

        public User ConvertToUser(UserViewModel userViewModel, string role)
        {
            User = new User(userViewModel.UserID, userViewModel.Name, userViewModel.Email, userViewModel.Password, role);
            return User;
        }

        public UserViewModel ConvertToUserViewModel(User user)
        {
            UserViewModel = new UserViewModel()
            {
                UserID = user.UserID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role
            };
            return UserViewModel;
        }

        public Group ConvertToGroup(GroupViewModel groupViewModel)
        {
            Group = new Group(groupViewModel.GroupID, groupViewModel.GroupName, groupViewModel.Email, groupViewModel.SummonerAccountID);
            return Group;
        }

        public GroupViewModel ConvertToGroupViewModel(Group group)
        {
            GroupViewModel = new GroupViewModel()
            {
                GroupID = group.GroupID,
                GroupName = group.Name,
                Email = group.Email,
                SummonerAccountID = group.SummonerAccountID
            };
            return GroupViewModel;
        }

        public SummonerViewModel ConvertToSummonerViewModel(Summoner summoner)
        {
            SummonerViewModel = new SummonerViewModel()
            {
                Name = summoner.Name,
                ProfileIconID = summoner.ProfileIconID,
                SummonerLevel = summoner.SummonerLevel,
                Region = summoner.Region,
            };
            return SummonerViewModel;
        }

        public MatchViewModel ConvertToMatchViewModel(Match match)
        {
            MatchViewModel = new MatchViewModel()
            {
                Role = match.Role,
                Season = match.Season,
                PlatformID = match.PlatformID,
                Champion = match.Champion,
                Lane = match.Lane,
                Timestamp = match.Timestamp
            };
            return MatchViewModel;
        }
    }
}
