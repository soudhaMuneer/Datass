using AutoMapper;
using MVCExercise.Dto;
using MVCExercise.Models;

namespace MVCExercise.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<CompanyDto, Company>().ReverseMap();
            CreateMap<MemberDto, CompanyMember>().ReverseMap();


        }
        
    }
}
