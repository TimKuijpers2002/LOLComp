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

        public async Task<List<Summoner>> FindSummonerByName(string summonerName)
        {
            var summonerList = new List<Summoner>();
            var summonerDTOs = await Factory.RequesterConnectionHandler.RequestSummonerData(summonerName);
            foreach(var summonerDTO in summonerDTOs)
            {
                summonerList.Add(converter.ConvertToSummoner(summonerDTO));
            }
            return summonerList;
        }

        public async Task<Summoner> FindSummonerByNameAndRegion(string summonerName, string region)
        {
            var summonerDTO = await Factory.RequesterConnectionHandler.RequestSummonerDataWithRegion(summonerName, region);
            var summoner = converter.ConvertToSummoner(summonerDTO);

            return summoner;
        }
    }
}
