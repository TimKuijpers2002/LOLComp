using DAL.RegionEnum;
using Interfaces.Interfaces;
using System;
using System.Net.Http;
using System.Text;
using DTO;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace DAL.APIContext
{
    public class Requester : IRequester
    {
        private readonly APIKeyHandler apiKeyHandler;

        public Requester(APIKeyHandler _apiKeyHandler)
        {
            apiKeyHandler = _apiKeyHandler;
        }

        private Exception _Exception(string message)
        {
            return new Exception(message);
        }

        public async Task<List<SummonerDTO>> RequestSummonerData(string summonerName)
        {
            var apiKey = apiKeyHandler.UseRiotKey();
            var summonerList = new List<SummonerDTO>();

            foreach (var region in (Regions[])Enum.GetValues(typeof(Regions)))
            {
                var URL = "https://" + region + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerName + "?api_key=" + apiKey;

                using var client = new HttpClient();
                var response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    JObject jObject = JObject.Parse(await response.Content.ReadAsStringAsync());
                    JToken jUser = jObject;


                    SummonerDTO summonerDTO = new SummonerDTO()
                    {
                        ID = (string)jUser["id"],
                        AccountID = (string)jUser["accountId"],
                        PuuID = (string)jUser["puuid"],
                        Name = (string)jUser["name"],
                        ProfileIconID = (int)jUser["profileIconId"],
                        RevisionDate = (long)jUser["revisionDate"],
                        SummonerLevel = (int)jUser["summonerLevel"],
                        Region = region.ToString()
                        
                    };
                    summonerList.Add(summonerDTO);
                }
                else
                {
                    throw _Exception("There was an error trying to access the external API, try again later");
                }
            }
            if(summonerList.Any())
            {
                return summonerList;
            }
            else
            {
                throw _Exception("This summoner could not be found");
            }
            
        }
    }
}
