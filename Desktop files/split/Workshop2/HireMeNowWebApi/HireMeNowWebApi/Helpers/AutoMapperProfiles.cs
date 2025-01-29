using AutoMapper;
using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
			
            CreateMap<JobDto,Job>().ReverseMap();
		}
	}
}
