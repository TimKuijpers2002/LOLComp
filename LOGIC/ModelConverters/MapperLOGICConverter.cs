using AutoMapper;
using DTO.APIDto_s;
using LOGIC.Models;
using LOGIC.Models.APIModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.ModelConverters
{
    public class MapperLOGICConverter : Profile
    {
        public MapperLOGICConverter()
        {
            CreateMap<MatchDto, Match>()
                .BeforeMap((src, dest) => src.gameDuration /= 60);

            CreateMap<ParticipantStatsDto, ParticipantStats>();
            CreateMap<ParticipantStats, ComparedMatchStats>();
            CreateMap<ParticipantDto, Participant>();
            CreateMap<MasteryDto, Mastery>();
            CreateMap<RuneDto, Models.APIModels.Rune>();
            CreateMap<ParticipantTimelineDto, ParticipantTimeline>();
            CreateMap<PlayerDto, Player>();
            CreateMap<TeamBansDto, TeamBans>();
            CreateMap<TeamStatsDto, TeamStats>();
            CreateMap<ParticipantIdentityDto, ParticipantIdentity>();
        }
    }
}
