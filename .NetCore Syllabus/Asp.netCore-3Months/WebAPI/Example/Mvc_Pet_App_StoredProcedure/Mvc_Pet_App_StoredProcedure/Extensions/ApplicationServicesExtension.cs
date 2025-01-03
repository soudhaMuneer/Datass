using Microsoft.EntityFrameworkCore;
using Mvc_Pet_App_StoredProcedure.Models;
using Mvc_Pet_App_StoredProcedure.Repository;
using System.Runtime.CompilerServices;

namespace Mvc_Pet_App_StoredProcedure.Extensions
{
    public static class ApplicationServicesExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContextPool<PetAppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<PetRepository>();
            return services;


        }
    }
}
