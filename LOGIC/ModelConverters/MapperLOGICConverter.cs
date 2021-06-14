using AutoMapper;
using DTO.APIDto_s;
using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LOGIC.ModelConverters
{
    public class MapperLOGICConverter : Profile
    {
        public MapperLOGICConverter()
        {
            CreateMap<MatchDto, Match>();
        }
    }
}
