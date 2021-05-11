using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IRequester
    {
        void RequestSummonerData(string region, string summonerName);
    }
}
