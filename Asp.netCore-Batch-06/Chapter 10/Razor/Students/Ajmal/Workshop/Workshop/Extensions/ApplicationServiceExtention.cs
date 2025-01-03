using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Workshop.Helper;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Repository;
using Workshop.Services;

namespace Workshop.Extensions
{
    public static class ApplicationServiceExtention
    {
      public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRegisterUser,UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddDbContext<HireMeNowDbContext>(Options=>
            Options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            return services;
        }
    }
}
