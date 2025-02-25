﻿using Mvc_HireMeNow.Models;
using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Repositories;
using Mvc_HireMeNow.Services;
using HireMeNowWebApi.Helpers;
using Mvc_HireMeNow.Data.Repositories;
using Mvc_HireMeNow.Repositories;

namespace Mvc_HireMeNow.Extensions
{
	public static class ApplicationServiceExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContextPool<HireMeNowDbContext>(options =>
			options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
		);
			
			services.AddScoped<IPublicService, PublicService>();
			services.AddScoped<IUserRepository, UserRepository>();
			
            services.AddScoped<IUserService, UserService>();
			
			services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
			
			services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<ICompanyRepository, CompanyRepository>();
			
			return services;
			 
		}
	}
}