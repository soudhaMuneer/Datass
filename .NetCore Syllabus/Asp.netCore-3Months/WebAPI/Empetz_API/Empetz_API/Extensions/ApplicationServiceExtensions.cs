using Domain.Models;
using Domain;
using Domain.Service.Category.Interfaces;
using Domain.Service.Category;
using Domain.Service.Login;
using Domain.Service.Login.Interfaces;
using Domain.Service.Register;
using Domain.Service.Register.Interfaces;
using Domain.Service.User;
using Microsoft.EntityFrameworkCore;

using Domain.Service.User.Interfaces;
using DAL.Models;



namespace Empetz_API.Extensions
{
    public static class ApplicationServiceExtensions
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<EmpetzContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<ICategoryRequestService, CategoryRequestservice>();
            services.AddScoped<ICategoryRequestRepository, CategoryRepository>();
        
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICategoryRequestRepository, CategoryRepository>();
            services.AddScoped<ILoginRequestService, LoginRequestService>();
            services.AddScoped<ILoginRequestRepository, LoginRequestRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IPublicService, PublicService>();
            services.AddScoped<IPublicRepository, PublicRepository>();
       
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
                    return services;
        }
    }
}
