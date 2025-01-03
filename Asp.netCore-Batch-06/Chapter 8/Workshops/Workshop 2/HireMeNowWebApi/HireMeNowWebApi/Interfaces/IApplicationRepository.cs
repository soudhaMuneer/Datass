using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
	public interface IApplicationRepository
	{
		public List<Application> AllAppliedjobs();
		public void AddApplication(User user, Job job);
		
	}
}
		
