using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Repositories
{
	public class ApplicationRepository: IApplicationRepository
	{

		List<Application> _applications = new List<Application>();
		List<Application> newlist_ = new List<Application>();
		public List<Application> AllAppliedjobs()
		{
			return _applications.ToList();
		}
		public void AddApplication(User user, Job job)
		{
			_applications.Add(new Application(job, user, "Pending"));
		}
	
		
	}
}
