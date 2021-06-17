using AutoMapper;
using DAL_Factory;
using LOGIC.ModelConverters;
using LOGIC.Models;
using LOGIC.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Collections
{
    public class MatchCollection
    {
        private readonly IMapper _mapper;
        private static int matchesToGather = 10;

        public MatchCollection(IMapper mapper)
        {
            _mapper = mapper;
        }

        //MATCH ORDERING----------------------------------------------------------------------------*

        public async Task<List<Match>> GetMatchHistory(string summonerAccountID, string region, int championId)
        {
            var index = matchesToGather;
            var matchList = new List<Match>();
            if (championId != -1)
            {
                return await OrderMatchesByChampion(summonerAccountID, region, championId);
            }
            else
            {
                var matchDTOs = await Factory.RequesterConnectionHandler.RequestSummonerMatchHistory(region, summonerAccountID, index);
                foreach (var matchDTO in matchDTOs)
                {
                    var match = _mapper.Map<Match>(matchDTO);
                    GiveParticipantsKDA(match.participants);
                    matchList.Add(match);
                }
                return matchList;
            }
        }

        public async Task<List<Match>> OrderMatchesByChampion(string summonerAccountID, string region, int championId)
        {
            var index = matchesToGather;
            var matchList = new List<Match>();
            var matchDTOs = await Factory.RequesterConnectionHandler.RequestSummonerMatchHistory(region, summonerAccountID, index);
            foreach (var matchDTO in matchDTOs.Where(match => match.yourChampion == championId))
            {
                var match = _mapper.Map<Match>(matchDTO);
                var stats = match.participants.Where(part => part.championId == championId).ToList().First().stats;

                GiveParticipantsKDA(match.participants);
                matchList.Add(match);
            }
            return matchList;
        }

        //MATCH ORDERING----------------------------------------------------------------------------*

        //FACTOR CALCULATIONS-----------------------------------------------------------------------*

        public ComparedMatchStats GetFactorForDiffInMatches(ParticipantStats statsOldest, ParticipantStats statsNewest)
        {
            ComparedMatchStats matchFactors = new ComparedMatchStats();
            List<ParticipantStats> stats = new List<ParticipantStats>(); stats.Add(statsNewest); stats.Add(statsOldest);
            var properties = statsOldest.GetType().GetProperties();

            foreach (var prop in properties)
            {
                if(prop.PropertyType == typeof(int) && matchFactors.GetType().GetProperty(prop.Name) != null)
                {
                    var valueStatsOld = stringifyValue(prop.GetValue(statsOldest));
                    var valueStatsNew = stringifyValue(statsNewest.GetType().GetProperty(prop.Name).GetValue(statsNewest));

                    matchFactors.GetType().GetProperty(prop.Name).SetValue(matchFactors, CalculateFactor(valueStatsOld, valueStatsNew));
                }
                else if (prop.PropertyType == typeof(long) && matchFactors.GetType().GetProperty(prop.Name) != null)
                {
                    var valueStatsOld = stringifyValue(prop.GetValue(statsOldest));
                    var valueStatsNew = stringifyValue(statsNewest.GetType().GetProperty(prop.Name).GetValue(statsNewest));

                    matchFactors.GetType().GetProperty(prop.Name).SetValue(matchFactors, CalculateFactor(valueStatsOld, valueStatsNew));
                }
            }
            return matchFactors;
        }

        public string stringifyValue(object value)
        {
            return string.Format("{0}\r\n", value);
        }

        public double CalculateFactor(string valueOldStats, string valueNewStats)
        {
            var valueOfOldProp = double.Parse(valueOldStats);
            var valueOfNewProp = double.Parse(valueNewStats);
            if (valueOfOldProp == 0)
            {
                return valueOfNewProp;
            }
            else if(valueOfNewProp == 0)
            {
                return valueOfOldProp * -(valueOfOldProp/valueOfOldProp);
            }
            else
            {
                return valueOfOldProp / valueOfNewProp;
            }                  
        }

        //FACTOR CALCULATIONS-----------------------------------------------------------------------*

        //KDA CALCULATIONS--------------------------------------------------------------------------*

        public double CalculateKDA(ParticipantStats stats)
        {
            return Convert.ToDouble(stats.kills + stats.assists) / Convert.ToDouble(stats.deaths);
        }

        public void GiveParticipantsKDA(List<Participant> participants)
        {
            foreach(var participant in participants)
            {
                participant.stats.GetType().GetProperty("kda").SetValue(participant.stats, CalculateKDA(participant.stats));
            }
        }

        //KDA CALCULATIONS--------------------------------------------------------------------------*
    }
}
