using Microsoft.EntityFrameworkCore;
using MVCExam.Helper;
using MVCExam.Interface;
using MVCExam.Models;
using MVCExam.Respository;
using MVCExam.Service;
using Microsoft.AspNetCore.Http;


namespace MVCExam.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config) 
        {

            services.AddDbContextPool<PersonDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddHttpContextAccessor();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddHttpContextAccessor();
            services.AddScoped<IPersonRepo, PersonRepository>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddControllersWithViews();
            return services;

            
        }

    }
}
 