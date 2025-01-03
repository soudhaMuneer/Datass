using Microsoft.EntityFrameworkCore;
using RazorWorkshopWithDB.Helpers;
using RazorWorkshopWithDB.Interface;
using RazorWorkshopWithDB.Model;
using System.Runtime.InteropServices;

namespace RazorWorkshopWithDB.Extensions
{
    public static  class ApplicationServiceExtension 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
           
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddDbContext<HireMeNowDBContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddScoped<IUserRepository, IUserRepository>();
            services.AddScoped<IUserService, IUserService>();

            services.AddScoped<HireMeNowDBContext>();
            return services;
        }
    }
}
