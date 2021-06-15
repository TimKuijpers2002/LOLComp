using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models.APIModels
{
    public class Player
    {
        public int profileIcon { get; private set; }
        public string accountId { get; private set; }
        public string matchHistoryUri { get; private set; }
        public string currentAccountId { get; private set; }
        public string curentPlatformId { get; private set; }
        public string summonerName { get; private set; }
        public string summonerId { get; private set; }
        public string platformId { get; private set; }
    }
}
