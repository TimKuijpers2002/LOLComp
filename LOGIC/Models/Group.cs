using DAL_Factory;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models
{
    public class Group
    {
        public int GroupID { get; private set; }
        public string Name { get; private set; }

        public Group(int groupID, string name)
        {
            GroupID = groupID;
            Name = name;
        }

        public void UpdateGroup(Group group)
        {
            var tempID = 0;
            GroupDTO UpdatedGroup = new GroupDTO()
            {
                GroupID = tempID,
                Name = group.Name,
            };

            Factory.groupConnectionHandler.UpdateGroup(UpdatedGroup);
        }
    }
}
