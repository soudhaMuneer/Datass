using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IApplicationRepository
	{
		public List<Application> GetAll(Guid userId);
		public void AddApplication(User user, Job job);
        List<Application> GetAllByCompany(Guid companyId);
    }
}
