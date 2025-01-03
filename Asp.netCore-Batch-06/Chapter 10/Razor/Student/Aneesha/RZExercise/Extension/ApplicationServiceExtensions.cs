using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RZExercise.DAL;
using RZExercise.Helper;
using RZExercise.Interface;
using RZExercise.Repository;
using RZExercise.Service;

namespace RZExercise.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services,IConfiguration config)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepo,UserRepository>();

            services.AddScoped<IJobRepo,JobRepository>();
            services.AddScoped<IJobService,JobService>();

            services.AddScoped<IApplyRepo,ApplyRepository>();
            services.AddScoped<IApplyService,ApplyService>();

            services.AddScoped<IInterviewRepo,InterviewRepository>();
            services.AddScoped<IInterviewService,InterviewService>();

            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddDbContext<SeekerDBContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddDbContext<SeekerDBContext>();
            return services;
        }
    }
}
