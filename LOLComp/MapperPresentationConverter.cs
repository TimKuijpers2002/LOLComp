using AutoMapper;
using LOGIC.Models;
using LOLComp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LOLComp
{
    public class MapperPresentationConverter : Profile
    {
        public MapperPresentationConverter()
        {
            CreateMap<Match, MatchViewModel>();
        }
    }
}
