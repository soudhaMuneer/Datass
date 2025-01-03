using AutoMapper;
using RZExercise.Dto;
using RZExercise.Models;

namespace RZExercise.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        { 
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<InterviewDto, Interview>().ReverseMap();
            CreateMap<ApplyDto,Apply>().ReverseMap();
          
            
        }
    }
}
