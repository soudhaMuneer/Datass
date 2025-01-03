using System;
using AutoMapper;
using BlazorworkShop.Dtos;
using BlazorworkShop.Models;

namespace BlazorworkShop.Helpers
{
	public class AutoMapperProfile: Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<UserDto, User>().ReverseMap();
			CreateMap<UserProfileDto, User>().ReverseMap();
			CreateMap<InterviewDto, Interview>().ReverseMap();
			CreateMap<CompanyDto, Company>().ReverseMap();
			CreateMap<JobDto, Job>().ReverseMap();
		}
	}
}

