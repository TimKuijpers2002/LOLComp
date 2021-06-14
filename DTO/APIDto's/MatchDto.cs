using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.APIDto_s
{
    public class MatchDto
    {
        public long gameId { get; set; }
        public List<ParticipantIdentityDto> participantIdentities { get; set; }
        public int queueId { get; set; }
        public string gameType { get; set; }
        public long gameDuration { get; set; }
        public List<TeamStatsDto> teams { get; set; }
        public string platformId { get; set; }
        public long gameCreation { get; set; }
        public int seasonId { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public string gameMode { get; set; }
        public List<ParticipantDto> participants { get; set; }
    }
}
