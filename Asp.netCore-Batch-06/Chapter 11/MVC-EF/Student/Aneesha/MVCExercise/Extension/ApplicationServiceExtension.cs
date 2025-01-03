using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCExercise.Interface;
using MVCExercise.Models;
using MVCExercise.Service;

namespace MVCExercise.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IMemberService, MemberService>();
            return services;
        }
    }
}
