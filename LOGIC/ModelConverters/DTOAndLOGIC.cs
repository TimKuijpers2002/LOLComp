using DTO;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.ModelConverters
{
    public class DTOAndLOGIC
    {
        private User user { get; set; }
        private UserDTO userDTO { get; set; }
        private Group group { get; set; }
        private GroupDTO groupDTO { get; set; }

        public User ConvertToUser(UserDTO userDTO)
        {
            user = new User(userDTO.UserID, userDTO.Name, userDTO.Email, userDTO.Password);
            return user;
        }

        public UserDTO ConvertToUserDTO(User user)
        {
            userDTO = new UserDTO()
            {
                UserID = user.UserID,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
            return userDTO;
        }

        public Group ConvertToGroup(GroupDTO groupDTO)
        {
            group = new Group(groupDTO.GroupID, groupDTO.Name);
            return group;
        }

        public GroupDTO ConvertToGroupDTO(Group group)
        {
            groupDTO = new GroupDTO()
            {
                GroupID = group.GroupID,
                Name = group.Name
            };
            return groupDTO;
        }
    }
}
