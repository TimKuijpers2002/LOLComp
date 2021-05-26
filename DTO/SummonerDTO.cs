using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class SummonerDTO
    {  
        public string ID { get; set; }
        public string AccountID { get; set; }
        public string PuuID { get; set; }
        public string Name { get; set; }
        public int ProfileIconID { get; set; }
        public long RevisionDate { get; set; }
        public int SummonerLevel { get; set; }
        public string Region { get; set; }
    }
}
