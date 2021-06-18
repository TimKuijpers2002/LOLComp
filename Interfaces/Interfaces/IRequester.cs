using DTO;
using DTO.APIDto_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IRequester
    {
        Task<List<SummonerDTO>> RequestSummonerData(string summonerName);
        Task<SummonerDTO> RequestSummonerDataWithRegion(string summonerName, string region);
        Task<List<MatchDto>> RequestSummonerMatchHistory(string region, string summonerAccountID, int index);
        Task<MatchDto> RequestMatchStats(string region, long matchID);
        Task<ChampionDto> RequestChampions(int championId);
    }
}
