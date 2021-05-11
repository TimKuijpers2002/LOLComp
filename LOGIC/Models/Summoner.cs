using DAL_Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.Models
{
    public class Summoner
    {
        public void TestRequest(string region, string summonerName)
        {
            Factory.RequesterConnectionHandler.RequestSummonerData(region, summonerName);
        }
    }
}
