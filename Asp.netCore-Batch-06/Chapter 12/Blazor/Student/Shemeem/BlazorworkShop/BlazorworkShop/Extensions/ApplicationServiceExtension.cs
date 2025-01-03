using System;
using BlazorworkShop.Helpers;
using BlazorworkShop.Interface;
using BlazorworkShop.Models;
using BlazorworkShop.Repository;
using BlazorworkShop.Services;
using Microsoft.EntityFrameworkCore;

namespace BlazorworkShop.Extensions
{
	public static class ApplicationServiceExtension
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration configuration)
		{
			services.AddDbContextPool<HireMeNowDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            services.AddScoped<IUserService, UserService>();
			services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            return services;
		}
	}
}

