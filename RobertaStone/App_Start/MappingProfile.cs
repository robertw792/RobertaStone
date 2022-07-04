using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using RobertaStone.Dtos;
using RobertaStone.Models;

namespace RobertaStone.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Lexis, LexisDto>();
            Mapper.CreateMap<LexisDto, Lexis>();
        }
    }
}