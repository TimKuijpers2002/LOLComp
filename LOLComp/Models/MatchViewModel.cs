using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class MatchViewModel
    {
        public string Role { get; set; }
        public int Season { get; set; }
        public string PlatformID { get; set; }
        public int Champion { get; set; }
        public string Lane { get; set; }
        public long Timestamp { get; set; }
    }
}
