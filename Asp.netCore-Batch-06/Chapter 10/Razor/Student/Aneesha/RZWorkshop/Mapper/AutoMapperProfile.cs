using AutoMapper;
using RZWorkshop.DTO;
using RZWorkshop.Models;

namespace RZWorkshop.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() 
        { 
            CreateMap<JobDto,Jobss>().ReverseMap();
        }
    }
}
