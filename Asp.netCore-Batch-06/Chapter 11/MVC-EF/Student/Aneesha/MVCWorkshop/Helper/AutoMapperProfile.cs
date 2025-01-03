using AutoMapper;
using MVCWorkshop.Dtos;
using MVCWorkshop.Models;

namespace MVCWorkshop.Helper
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto,User>().ReverseMap();
            CreateMap<JobDto,Job>().ReverseMap();
        }
    }
}
