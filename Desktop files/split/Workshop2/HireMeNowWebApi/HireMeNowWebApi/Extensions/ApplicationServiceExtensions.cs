

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
			services.AddScoped<IJobService, JobService>();
			services.AddSingleton<IJobRepository, JobRepository>();
	           services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
          
            return services;
        }
    }
}