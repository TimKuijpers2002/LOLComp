using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IGroupHandler
    {
        void CreateGroup(GroupDTO G1);
        List<GroupDTO> GetGroups();
        void UpdateGroup(GroupDTO G1);
        void DeleteGroup(int GroupID);
        List<GroupDTO> GetGroupsWithUserID(int userID);
    }
}
