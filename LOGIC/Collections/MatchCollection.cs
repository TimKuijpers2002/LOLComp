using AutoMapper;
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
        private readonly IMapper _mapper;

        public MatchCollection(IMapper mapper)
        {
            converter = new DTOAndLOGICConverters();
            _mapper = mapper;
        }
        public async Task<List<Match>> GetMatchHistory(string summonerAccountID, string region)
        {
            var matchList = new List<Match>();
            var matchDTOs = await Factory.RequesterConnectionHandler.RequestSummonerMatchHistory(region, summonerAccountID);
            foreach (var matchDTO in matchDTOs)
            {
                var match = _mapper.Map<Match>(matchDTO);
                matchList.Add(match);
            }
            return matchList;
        }
    }
}
