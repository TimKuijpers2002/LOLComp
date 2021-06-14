﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp.Models
{
    public class MatchViewModel
    {
        //public List<ParticipantIdentityDto> participantIdentities { get; private set; }
        public string gameType { get; private set; }
        public long gameDuration { get; private set; }
        //public List<TeamStatsDto> teams { get; private set; }
        public string platformId { get; private set; }
        public int seasonId { get; private set; }
        public string gameVersion { get; private set; }
        public int mapId { get; set; }
        public string gameMode { get; private set; }
        //public List<ParticipantDto> participants { get; private set; }
    }
}