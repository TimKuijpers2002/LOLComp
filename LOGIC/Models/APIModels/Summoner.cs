using DAL_Factory;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Models
{
    public class Summoner
    {
        public string ID { get; private set; }
        public string AccountID { get; private set; }
        public string PuuID { get; private set; }
        public string Name { get; private set; }
        public int ProfileIconID { get; private set; }
        public long RevisionDate { get; private set; }
        public int SummonerLevel { get; private set; }
        public string Region { get; private set; }

        public Summoner(string id, string accountID, string puuID, string name, int profileIconID, long revisionDate, int summonerLevel, string region)
        {
            ID = id;
            AccountID = accountID;
            PuuID = puuID;
            Name = name;
            ProfileIconID = profileIconID;
            RevisionDate = revisionDate;
            SummonerLevel = summonerLevel;
            Region = region;
        }
    }
}
