using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Interfaces
{
    public interface IRequester
    {
        Task<SummonerDTO> RequestSummonerData(string summonerName);
    }
}
