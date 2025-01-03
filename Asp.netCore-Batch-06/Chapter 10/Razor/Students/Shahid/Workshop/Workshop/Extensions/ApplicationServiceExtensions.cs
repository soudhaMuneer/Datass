using Microsoft.EntityFrameworkCore;
using Workshop.Helpers;
using Workshop.Interface;
using Workshop.Models;
using Workshop.Reprosetry;
using Workshop.Services;

namespace Workshop.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUserService, UserServices>();
            services.AddScoped<IUserReprosetry, UserReprostry>();

            services.AddDbContext<JobPortalDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
           
            return services;
        }

    }
}
