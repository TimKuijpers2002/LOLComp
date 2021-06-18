using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.APIDto_s
{
    public class ChampionInfo
    {
        public int attack { get; set; }
        public int defense { get; set; }
        public int magic { get; set; }
        public int difficulty { get; set; }
        public ChampionImage image { get; set; }
        public string[] tags { get; set; }
        public string partype { get; set; }
        public ChampionStats stats { get; set; }
    }
}
