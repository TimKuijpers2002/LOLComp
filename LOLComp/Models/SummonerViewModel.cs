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

        public List<MatchViewModel> Matches(List<Match> matches)
        {
            foreach(var match in matches)
            {
                MatchViewModel viewModel = new MatchViewModel()
                {
                    Role = match.Role,
                    Season = match.Season,
                    PlatformID = match.PlatformID,
                    Champion = match.Champion,
                    Lane = match.Lane,
                    Timestamp = match.Timestamp
                };
                matchViewModels.Add(viewModel);
            }
            return matchViewModels;
        }
    }
}
