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
        private DTOAndLOGICConverters converter;
        public int GroupID { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string SummonerAccountID { get; private set; }

        public Group(int groupID, string name, string email, string summonerAccountID)
        {
            GroupID = groupID;
            Name = name;
            Email = email;
            SummonerAccountID = summonerAccountID;
        }

        public void UpdateGroup(Group group)
        {
            converter = new DTOAndLOGICConverters();
            //FIX het tempID in controller nog!
            Factory.GroupConnectionHandler.UpdateGroup(converter.ConvertToGroupDTO(group));
        }
    }
}
