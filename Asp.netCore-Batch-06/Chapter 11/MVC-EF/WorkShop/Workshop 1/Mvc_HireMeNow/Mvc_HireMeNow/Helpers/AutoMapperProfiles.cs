using AutoMapper;
using Mvc_HireMeNow.Dtos;
using Mvc_HireMeNow.Models;

namespace HireMeNowWebApi.Helpers
{
	public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDto, User>().ReverseMap();
			
           
            CreateMap<JobDto,Job>().ReverseMap();
         
		}
	}
}
