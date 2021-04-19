using DAL_Factory;
using DTO;
using LOGIC.ModelConverters;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models
{
    public class Group
    {
        private DTOAndLOGIC Converter { get; set; }
        public int GroupID { get; private set; }
        public string Name { get; private set; }

        public Group(int groupID, string name)
        {
            GroupID = groupID;
            Name = name;
        }

        public void UpdateGroup(Group group)
        {
            Converter = new DTOAndLOGIC();
            //FIX het tempID in controller nog!
            Factory.groupConnectionHandler.UpdateGroup(Converter.ConvertToGroupDTO(group));
        }
    }
}
