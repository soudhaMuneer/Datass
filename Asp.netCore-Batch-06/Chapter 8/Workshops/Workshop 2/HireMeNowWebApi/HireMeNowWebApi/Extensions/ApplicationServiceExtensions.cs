

using HireMeNowWebApi.Helpers;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Repositories;
using HireMeNowWebApi.Services;

namespace HireMeNowWebApi.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<IUserRepository, UserRepository>();
			services.AddScoped<IJobService, JobService>();
			services.AddSingleton<IJobRepository, JobRepository>();
			services.AddScoped<IApplicationService, ApplicationService>();
			services.AddSingleton<IApplicationRepository, ApplicationRepository>();
		
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
          
            return services;
        }
    }
}