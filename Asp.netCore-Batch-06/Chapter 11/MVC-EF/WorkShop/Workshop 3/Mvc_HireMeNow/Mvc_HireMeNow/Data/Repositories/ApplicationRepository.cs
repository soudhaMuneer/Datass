using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Repositories
{
	public class ApplicationRepository : IApplicationRepository
	{
		HireMeNowDbContext _context = new HireMeNowDbContext();
        public ApplicationRepository(HireMeNowDbContext context)
        {
            _context = context;
        }
       
		

		public void AddApplication(Application application)
		{
			_context.Applications.Add(application);
			_context.SaveChanges();
		}
	
	
	}
}
