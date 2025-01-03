using AutoMapper;
using Chapter10Exercise1.Dtos;
using Chapter10Exercise1.Models;

namespace Chapter10Exercise1.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDto, Users>().ReverseMap();
        }
    }
}
