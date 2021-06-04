using DAL_Factory;
using DTO;
using LOGIC.ModelConverters;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LOGIC.Collections
{
    public class GroupCollection
    {
        private DTOAndLOGICConverters converter;
        private List<Group> groups;

        public GroupCollection()
        {
            converter = new DTOAndLOGICConverters();
        }
        public void CreateGroup(Group group, User user)
        {
            Factory.GroupConnectionHandler.CreateGroup(converter.ConvertToGroupDTO(group), converter.ConvertToUserDTO(user));
        }

        public List<Group> GetGroups()
        {
            var groupDTOs = Factory.GroupConnectionHandler.GetGroups();
            groups = new List<Group>();
            foreach (var groupDTO in groupDTOs)
            {
                groups.Add(converter.ConvertToGroup(groupDTO));
            }
            return groups;
        }

        public List<Group> GetGroupsWithUserID(int userID)
        {
            var groupDTOs = Factory.GroupConnectionHandler.GetGroupsWithUserID(userID);
            groups = new List<Group>();
            foreach (var groupDTO in groupDTOs)
            {
                groups.Add(converter.ConvertToGroup(groupDTO));
            }
            return groups;
        }

        public void DeleteGroup(User user, string name)
        {
            var groupDTOs = GetGroupsWithUserID(user.UserID);
            var groupToDelete = groupDTOs.Where(g => g.Name == name).ToList().First();
            Factory.GroupConnectionHandler.DeleteGroup(groupToDelete.GroupID);
        }
    }
}
