using DTO;
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
        Task<List<MatchDTO>> RequestSummonerMatchHistory(string region, string summonerAccountID);
    }
}
