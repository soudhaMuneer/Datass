using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Models;

namespace HireMeNow_BlazorApp.Repositories
{
	public class ApplicationRepository: IApplicationRepository
	{
        HireMeNowDbContext _context;
        public ApplicationRepository(HireMeNowDbContext context)
        {
            _context = context;
        }

		public void AddApplication(Application application)
		{
			_context.Applications.Add(application);
			_context.SaveChanges();
		}

		public List<Application> GetAll(Guid userId)
		{
			return _context.Applications.Where(e => e.User.Id == userId).Include(x => x.Job).ToList();
		}
		

        public List<Application> GetAllByCompany(Guid companyId)
        {
            return _context.Applications.Where(e => e.CompanyId== companyId).Include(x => x.Job).Include(x => x.User).Include(x => x.User.Experiences).Include(x=>x.User.Qualifications).ToList();
        }
		public Application GetApplication(Guid appid)
		{
			return _context.Applications.Where(e => e.Id == appid).Include(a => a.Job).Include(b => b.User).Include(c => c.Company).FirstOrDefault();
		}
	}
}
