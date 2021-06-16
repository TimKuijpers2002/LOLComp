using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class MatchViewModel
    {
        //public List<ParticipantIdentityDto> participantIdentities { get; private set; }
        public int yourChampion { get; set; }
        public string gameType { get; set; }
        public long gameDuration { get; set; }
        //public List<TeamStatsDto> teams { get; private set; }
        public string platformId { get; set; }
        public int seasonId { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public string gameMode { get; set; }
        //public List<ParticipantDto> participants { get; private set; }
    }
}
