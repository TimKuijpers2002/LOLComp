using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models.APIModels
{
    public class TeamStats
    {
        public int towerKills { get; private set; }
        public int riftHeraldKills { get; private set; }
        public bool firstBlood { get; private set; }
        public int inhibitorKills { get; private set; }
        public List<TeamBans> bans { get; private set; }
        public bool firstBaron { get; private set; }
        public bool firstDragon { get; private set; }
        public int dragonKills { get; private set; }
        public int baronKills { get; private set; }
        public bool firstInhibitor { get; private set; }
        public bool firstRiftHerald { get; private set; }
        public int teamId { get; private set; }
        public string win { get; private set; }
    }
}
