using AutoMapper;
using MVCExam.Dto;
using MVCExam.Models;

namespace MVCExam.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<PersonDto,Person>().ReverseMap();
        }
    }
}
