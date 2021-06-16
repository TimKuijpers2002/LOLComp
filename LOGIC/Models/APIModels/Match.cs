using DTO.APIDto_s;
using LOGIC.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models
{
    public class Match
    {
        public int yourChampion { get; private set; }
        public List<ParticipantIdentity> participantIdentities { get; private set; }
        public string gameType { get; private set; }
        public long gameDuration { get; private set; }
        public List<TeamStats> teams { get; private set; }
        public string platformId { get; private set; }
        public int seasonId { get; private set; }
        public string gameVersion { get; private set; }
        public int mapId { get; private set; }
        public string gameMode { get; private set; }
        public List<Participant> participants { get; private set; }
    }
}
