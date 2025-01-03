using AutoMapper;
using Workshop.Dtos;
using Workshop.Models;

namespace Workshop.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDto,User>().ReverseMap();
        }
    }
}
