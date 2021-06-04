using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class GroupViewModel
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string Email { get; set; }
        public string SummonerAccountID { get; set; }
    }
}
