using HireMeNow_BlazorApp.Helpers;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Repositories;
using HireMeNow_BlazorApp.Services;
using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Models;

namespace HireMeNow_BlazorApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
			services.AddDbContextPool<HireMeNowDbContext>(options =>
		options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
	);
			     services.AddScoped<IUserService, UserService>();
			     services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<IInterviewServices, InterviewServices>();
			services.AddScoped<IInterviewRepository, InterviewRepository>();
			services.AddScoped<IJobService, JobService>();
			services.AddScoped<IJobRepository, JobRepository>();
			services.AddScoped<ICompanyRepository, CompanyRepository>();
			    services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<IApplicationService, ApplicationService>();
			services.AddScoped<IApplicationRepository, ApplicationRepository>();

			services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
          
            return services;
        }
    }
}