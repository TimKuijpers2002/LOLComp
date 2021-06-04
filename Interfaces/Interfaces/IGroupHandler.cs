using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IGroupHandler
    {
        void CreateGroup(GroupDTO Group, UserDTO User);
        List<GroupDTO> GetGroups();
        void UpdateGroup(GroupDTO Group);
        void DeleteGroup(int GroupID);
        List<GroupDTO> GetGroupsWithUserID(int userID);
        void ConnectUserAndGroup(string groupName, UserDTO User);
        string GetGroupIDWithGroupName(string email, string name);
    }
}
