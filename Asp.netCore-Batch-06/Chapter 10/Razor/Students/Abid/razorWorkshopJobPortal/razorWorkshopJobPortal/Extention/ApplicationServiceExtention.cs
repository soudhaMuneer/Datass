using Microsoft.EntityFrameworkCore;
using razorWorkshopJobPortal.Interfaces;
using razorWorkshopJobPortal.Models;
using razorWorkshopJobPortal.Helpers;
using razorWorkshopJobPortal.Repository;
using razorWorkshopJobPortal.Services;

namespace razorWorkshopJobPortal.Extention
{
	public static  class ApplicationServiceExtention
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
		{
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutomappingProfile).Assembly);
			services.AddDbContext<jobportDbContext>(options =>
				options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
			);

			return services;
		}
	}
}
