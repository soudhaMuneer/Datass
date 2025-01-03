using AutoMapper;
using HireMeNow_BlazorApp.Dtos;
using HireMeNow_BlazorApp.Models;
using System.Collections;

namespace HireMeNow_BlazorApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserProfileDto, User>().ReverseMap();
            CreateMap<InterviewDto, Interview>().ReverseMap();
            CreateMap<CompanyDto, Company>().ReverseMap();
            //CreateMap<Company, CompanyDto>().ForMember(dest => dest.Base64Image, opt => opt.MapFrom<ImageConverter>());
            //CreateMap<CompanyDto, Company>().ForMember(dest => dest.ImageData, opt => opt.MapFrom<ImageByteConverter>());
            CreateMap<JobDto,Job>().ReverseMap();
        }
    }
    //public class ImageConverter : IValueResolver<Company, CompanyDto, string>
    //{
    //    public string Resolve(Company source, CompanyDto destination, string destMember, ResolutionContext context)
    //    {
    //        if (source.ImageData != null)
    //        {
    //            // Convert the byte array to Base64-encoded string
    //            return Convert.ToBase64String(source.ImageData);
    //        }

    //        return null;
    //    }
    //}

    //public class ImageByteConverter : IValueResolver<CompanyDto, Company, byte[]>
    //{

    //    public byte[] Resolve(CompanyDto source, Company destination, byte[] destMember, ResolutionContext context)
    //    {
    //        return Convert.FromBase64String(source.Base64Image);
    //    }
    //}
 
}
