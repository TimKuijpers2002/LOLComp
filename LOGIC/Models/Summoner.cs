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
        public string ID { get; set; }
        public string AccountID { get; set; }
        public string PuuID { get; set; }
        public string Name { get; set; }
        public int ProfileIconID { get; set; }
        public long RevisionDate { get; set; }
        public int SummonerLevel { get; set; }

        public Summoner(string id, string accountID, string puuID, string name, int profileIconID, long revisionDate, int summonerLevel)
        {
            ID = id;
            AccountID = accountID;
            PuuID = puuID;
            Name = name;
            ProfileIconID = profileIconID;
            RevisionDate = revisionDate;
            SummonerLevel = summonerLevel;
        }

        public Summoner(SummonerDTO summonerDTO)
            : this(summonerDTO.ID, summonerDTO.AccountID, summonerDTO.PuuID, summonerDTO.Name, summonerDTO.ProfileIconID, summonerDTO.RevisionDate,summonerDTO.SummonerLevel)
        {

        }
    }
}
