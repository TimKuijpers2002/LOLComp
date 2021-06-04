using DAL_Factory;
using LOGIC.ModelConverters;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Collections
{
    public class MatchCollection
    {
        private readonly DTOAndLOGICConverters converter;

        public MatchCollection()
        {
            converter = new DTOAndLOGICConverters();
        }
        public async Task<List<Match>> GetMatchHistory(string summonerAccountID, string region)
        {
            var matchList = new List<Match>();
            var matchDTOs = await Factory.RequesterConnectionHandler.RequestSummonerMatchHistory(region, summonerAccountID);
            foreach (var matchDTO in matchDTOs)
            {
                matchList.Add(converter.ConvertToMatch(matchDTO));
            }
            return matchList;
        }
    }
}
