﻿using LOGIC.Models;
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
        private UserModel userViewModel { get; set; }
        private Group group { get; set; }
        private GroupModel groupViewModel { get; set; }

        public User ConvertToUser(UserModel userViewModel, string role)
        {
            user = new User(userViewModel.UserID, userViewModel.Name, userViewModel.Email, userViewModel.Password, role);
            return user;
        }

        public UserModel ConvertToUserViewModel(User user)
        {
            userViewModel = new UserModel()
            {
                UserID = user.UserID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                Role = user.Role
            };
            return userViewModel;
        }

        public Group ConvertToGroup(GroupModel groupViewModel)
        {
            group = new Group(groupViewModel.GroupID, groupViewModel.GroupName);
            return group;
        }

        public GroupModel ConvertToGroupViewModel(Group group)
        {
            groupViewModel = new GroupModel()
            {
                GroupID = group.GroupID,
                GroupName = group.Name
            };
            return groupViewModel;
        }
    }
}
