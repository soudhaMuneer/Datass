using AutoMapper;
using JobPortalApplication.Models;
using RazorWorkshopWithDB.DTO;
namespace RazorWorkshopWithDB.Helpers
    
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UserDto, User>().ReverseMap();
        }
    }
}
