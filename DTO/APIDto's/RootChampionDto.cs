using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.APIDto_s
{
    public class RootChampionDto
    {
        public string type { get; set; }
        public string version { get; set; }
        public string format { get; set; }
        public Dictionary<string, ChampionDto> data { get; set; }
    }
}
