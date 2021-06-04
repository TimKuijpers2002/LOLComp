using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models
{
    public class Match
    {
        public long GameId { get; private set; }
        public string Role { get; private set; }
        public int Season { get; private set; }
        public string PlatformID { get; private set; }
        public int Champion { get; private set; }
        public int Queue { get; private set; }
        public string Lane { get; private set; }
        public long Timestamp { get; private set; }

        public Match(long gameID, string role, int season, string platformID, int champion, int queue, string lane, long timestamp)
        {
            GameId = gameID;
            Role = role;
            Season = season;
            PlatformID = platformID;
            Champion = champion;
            Queue = queue;
            Lane = lane;
            Timestamp = timestamp;

        }
    }
}
