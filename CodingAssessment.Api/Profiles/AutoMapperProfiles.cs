using AutoMapper;
using CodingAssessment.Api.Dtos;
using CodingAssessment.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingAssessment.api.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Cat, CatDto>();
            CreateMap<CatDto, Cat>();
          

        }


    }
}
