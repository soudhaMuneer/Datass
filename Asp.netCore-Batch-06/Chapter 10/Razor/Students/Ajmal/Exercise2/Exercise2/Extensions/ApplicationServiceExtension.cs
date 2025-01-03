using Exercise2.Interface;
using Exercise2.Models;
using Microsoft.EntityFrameworkCore;
using Exercise2.Services;
using Exercise2.Helper;
using Exercise2.Repositories;
namespace Exercise2.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IInterview, InterviewService>();
            services.AddScoped<IJob, JobService>();
            services.AddScoped<IInterviewRepository,InterviewRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            services.AddDbContext<HireMeNowDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            return services;
        }
        }
}
