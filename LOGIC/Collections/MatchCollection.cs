using AutoMapper;
using DAL_Factory;
using LOGIC.ModelConverters;
using LOGIC.Models;
using LOGIC.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Collections
{
    public class MatchCollection
    {
        private readonly DTOAndLOGICConverters converter;
        private readonly IMapper _mapper;
        private static int matchesToGather = 10;
        private static int maxRequestIndex = 20;

        public MatchCollection(IMapper mapper)
        {
            converter = new DTOAndLOGICConverters();
            _mapper = mapper;
        }
        public async Task<List<Match>> GetMatchHistory(string summonerAccountID, string region, int championId)
        {
            var index = matchesToGather;
            var matchList = new List<Match>();
            if (championId != -1)
            {
                return await OrderMatchesByChampion(summonerAccountID, region, championId);
            }
            else
            {
                var matchDTOs = await Factory.RequesterConnectionHandler.RequestSummonerMatchHistory(region, summonerAccountID, index);
                foreach (var matchDTO in matchDTOs)
                {
                    var match = _mapper.Map<Match>(matchDTO);

                    matchList.Add(match);
                }
                return matchList;
            }
        }

        public async Task<List<Match>> OrderMatchesByChampion(string summonerAccountID, string region, int championId)
        {
            var index = matchesToGather;
            var matchList = new List<Match>();
            var matchDTOs = await Factory.RequesterConnectionHandler.RequestSummonerMatchHistory(region, summonerAccountID, index);
            foreach (var matchDTO in matchDTOs.Where(match => match.yourChampion == championId))
            {
                var match = _mapper.Map<Match>(matchDTO);

                matchList.Add(match);
            }
            return matchList;
        }

    }
}
