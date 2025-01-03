
using AutoMapper;
using Domain.Models;

using Domain.Service.Category.DTOs;
using Domain.Service.Login.DTOs;
using Domain.Models;

using Domain.Service.Register.DTOs;
using Domain.Service.User.DTO;

using Empetz_API.API.Category.RequestObject;
using Domain.Service.User.DTO;

using Empetz_API.API.Public.RequestObject;
using Empetz_API.API.User.RequestObject;

using Domain.Enums;

namespace Empetz_API.Extensions
{
    public class AutoMapperProfiles: AutoMapper.Profile
    {
        public AutoMapperProfiles()
		{
			CreateMap<UserSignUp,UserRegisterDto>().ReverseMap();
			CreateMap<UserRegisterDto, User>().ReverseMap();
            //CreateMap<PetPostRequest, PetPostDto>()
            //             .ForMember(dest => dest.Vaccinated, opt => opt.MapFrom(src => src.Vaccinated.HasValue ? (src.Vaccinated.Value ? Vaccinated.True : Vaccinated.False) : Vaccinated.False));


            CreateMap<User, PublicUserLoginDto>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<UserRequest, UserDto>();
        
         
            CreateMap<PetsCategory, CategoryDto>();
            CreateMap<CategoryDto, CategoryRequest>();
            CreateMap<UpdateUserDTO, User>();
            CreateMap<UpdateUserRequest, UpdateUserDTO>();
            CreateMap<CategoryUpdateDTo,PetsCategory>();
            CreateMap<CategoryUpdateRequest, CategoryUpdateDTo>();
            CreateMap<PetsCategory, CategoryUpdateDTo>();
          
            
			CreateMap<PetsCategory, CategoryAddDTO>();
            CreateMap<CategoryAddDTO, PetsCategory>();
            CreateMap<CategoryAddDTO, CategoryAddRequest>();
            CreateMap<CategoryAddRequest, CategoryAddDTO>();
          

        }


    }
}
