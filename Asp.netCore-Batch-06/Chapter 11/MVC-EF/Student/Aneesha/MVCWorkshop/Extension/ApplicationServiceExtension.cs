using Microsoft.EntityFrameworkCore;
using MVCWorkshop.DAL;
using MVCWorkshop.Models;

namespace MVCWorkshop.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContextPool<JobPortalDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

           return services;
        }
    }
}
