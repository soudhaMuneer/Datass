

using HireMeNow_BlazorApp.Helpers;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Repositories;
using HireMeNow_BlazorApp.Services;

namespace HireMeNow_BlazorApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserRepository>();
			
		
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
          
            return services;
        }
    }
}