using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DAL.APIContext
{
    public class Requester : IRequester
    {
        private APIKeyHandler apiKeyHandler;

        public Requester(APIKeyHandler _apiKeyHandler)
        {
            apiKeyHandler = _apiKeyHandler;
        }
        public async void RequestSummonerData(string region, string summonerName)
        {
            var URL = "https://" + region + ".api.riotgames.com/lol/summoner/v4/summoners/by-name/" + summonerName + "?api_key=" + apiKeyHandler.UseRiotKey();

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(URL);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
