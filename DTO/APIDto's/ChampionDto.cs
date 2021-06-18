using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.APIDto_s
{
    public class ChampionDto
    {
        public int id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string version { get; set; }
        public string blurb { get; set; }
        public ChampionInfo info { get; set; }
       
    }
}
