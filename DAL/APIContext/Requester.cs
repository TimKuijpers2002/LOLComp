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
using System.Text.Json;
using DTO.APIDto_s;

namespace DAL.APIContext
{
    public class Requester : IRequester
    {
        private readonly APIKeyHandler apiKeyHandler;

        public Requester(APIKeyHandler _apiKeyHandler)
        {
            apiKeyHandler = _apiKeyHandler;
        }

        private Exception Exception(string message)
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
            }
            if(summonerList.Any())
            {
                return summonerList;
            }
            else
            {
                throw Exception("This summoner could not be found");
            }
            
        }

        public async Task<SummonerDTO> RequestSummonerDataWithRegion(string summonerName, string region)
        {
            var apiKey = apiKeyHandler.UseRiotKey();

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
                return summonerDTO;

            }
            throw Exception("This summoner could not be found");

        }

        public async Task<List<MatchDto>> RequestSummonerMatchHistory(string region, string summonerAccountID, int index)
        {
            var apiKey = apiKeyHandler.UseRiotKey();
            var matchListNoStats = new List<MatchWithoutStatsDto>();
            var matchListStats = new List<MatchDto>();

            var URL = "https://" + region + ".api.riotgames.com/lol/match/v4/matchlists/by-account/" + summonerAccountID+ "?endIndex=" + index + "&api_key=" + apiKey;

            using var client = new HttpClient();
            var response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                string s = await response.Content.ReadAsStringAsync();

                var jsonDoc = JsonDocument.Parse(s);
                var matchesElement = jsonDoc.RootElement.GetProperty("matches").GetRawText();
                matchListNoStats = JsonSerializer.Deserialize<List<MatchWithoutStatsDto>>(matchesElement);
            }
            
            if (matchListNoStats.Any())
            {
                foreach(var matchDto in matchListNoStats)
                {
                    var match = await RequestMatchStats(region, matchDto.gameId);
                    match.yourChampion = matchDto.champion;
                    matchListStats.Add(match);
                }
                return matchListStats;
            }
            else
            {
                throw Exception("The match history of this summoner could not be found");
            }

        }

        public async Task<MatchDto> RequestMatchStats(string region, long matchID)
        {
            var apiKey = apiKeyHandler.UseRiotKey();
            var match = new MatchDto();

            var URL = "https://" + region + ".api.riotgames.com/lol/match/v4/matches/" + matchID + "?api_key=" + apiKey;

            using var client = new HttpClient();
            var response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                string s = await response.Content.ReadAsStringAsync();

                match = JsonSerializer.Deserialize<MatchDto>(await response.Content.ReadAsStringAsync());
            }
            return match;
        }

        //Not working yet
        public async Task<ChampionDto> RequestChampions(int championId)
        {
            var apiKey = apiKeyHandler.UseRiotKey();
            var champions = new List<ChampionDto>();
            string version = "11.12.1";

            var URL = "http://ddragon.leagueoflegends.com/cdn/" + version + "/data/en_GB/champion.json";

            using var client = new HttpClient();
            var response = await client.GetAsync(URL);
            if (response.IsSuccessStatusCode)
            {
                var championElement = JsonSerializer.Deserialize<RootChampionDto>(await response.Content.ReadAsStringAsync());
                var test = championElement;
            }
            return champions.First();
        }
    }
}
