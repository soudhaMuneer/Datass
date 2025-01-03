using AutoMapper;
using Workshop.DTOs;
using Workshop.Models;

namespace Workshop.Helper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<UserDtos, User>().ReverseMap();
        }
    }
}
