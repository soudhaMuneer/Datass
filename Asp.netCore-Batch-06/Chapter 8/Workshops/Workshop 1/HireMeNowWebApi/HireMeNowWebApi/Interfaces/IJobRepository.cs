using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
	public interface IJobRepository
	{
		Job PostJob(Job job);

		List<Job> GetJobs();
	}

	
}
