using DAL_Factory;
using DTO;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOGIC.Collections
{
    public class GroupCollection
    {
        private UserCollection userCollection;
        private List<Group> groups;

        public void CreateGroup(Group group)
        {
            var tempID = 0;
            GroupDTO NewGroup = new GroupDTO()
            {
                GroupID = tempID,
                Name = group.Name
            };

            Factory.groupConnectionHandler.CreateGroup(NewGroup);
        }

        public List<Group> GetGroups()
        {
            var groupDTOs = Factory.groupConnectionHandler.GetGroups();
            groups = new List<Group>();
            foreach (var groupDTO in groupDTOs)
            {
                groups.Add(new Group(groupDTO.GroupID, groupDTO.Name));
            }
            return groups;
        }

        public List<Group> GetGroupsWithUserID(int userID)
        {
            var groupDTOs = Factory.groupConnectionHandler.GetGroupsWithUserID(userID);
            groups = new List<Group>();
            foreach (var groupDTO in groupDTOs)
            {
                groups.Add(new Group(groupDTO.GroupID, groupDTO.Name));
            }
            return groups;
        }

        public void DeleteGroup(string email, string name)
        {
            userCollection = new UserCollection();
            var userDTO = userCollection.GetUserByEmail(email);
            var groupDTOs = GetGroupsWithUserID(userDTO.UserID);
            var groupToDelete = groupDTOs.Where(g => g.Name == name).ToList().First();
            Factory.groupConnectionHandler.DeleteGroup(groupToDelete.GroupID);
        }
    }
}
