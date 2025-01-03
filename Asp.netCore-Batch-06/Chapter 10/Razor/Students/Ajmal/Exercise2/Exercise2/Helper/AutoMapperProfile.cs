using AutoMapper;
using Exercise2.DTOs;
using Exercise2.Models;

namespace Exercise2.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDtos, User>().ReverseMap();
            CreateMap<InterviewDtos, Interview>().ReverseMap();
        }
    }
}
