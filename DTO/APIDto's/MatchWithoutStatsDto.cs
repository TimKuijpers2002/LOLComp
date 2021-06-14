using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.APIDto_s
{
    public class MatchWithoutStatsDto
    {
        public long gameId { get; set; }
        public string role { get; set; }
        public int season { get; set; }
        public int champion { get; set; }
        public string lane { get; set; }
    }
}
