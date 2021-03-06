using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class SummonerViewModel
    {
        public List<MatchViewModel> matchViewModels;
        public string Name { get; set; }
        public int ProfileIconID { get; set; }
        public int SummonerLevel { get; set; }
        public string Region { get; set; }
        public SummonerViewModel()
        {
            matchViewModels = new List<MatchViewModel>();
        }
    }
}
