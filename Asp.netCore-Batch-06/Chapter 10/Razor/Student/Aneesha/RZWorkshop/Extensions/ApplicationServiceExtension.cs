using Microsoft.EntityFrameworkCore;
using RZWorkshop.Mapper;
using RZWorkshop.Models;


// Then use the extension method explicitly:
// Specify the correct type or assembly


namespace RZWorkshop.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            //services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddDbContext<RzworkshopContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")
            ));
            services.AddScoped<RzworkshopContext>();
            return services;
        }
    }
}
