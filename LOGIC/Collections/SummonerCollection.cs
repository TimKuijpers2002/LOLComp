using DAL_Factory;
using DTO;
using LOGIC.ModelConverters;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Collections
{
    public class SummonerCollection
    {
        private readonly DTOAndLOGICConverters converter;

        public SummonerCollection()
        {
            converter = new DTOAndLOGICConverters();
        }

        public async Task<Summoner> FindSummonerByName(string summonerName)
        {
            var summonerDTO = await Factory.RequesterConnectionHandler.RequestSummonerData(summonerName);
            return converter.ConvertToSummoner(summonerDTO);
        }
    }
}
