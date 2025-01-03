using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IJobRepository
    {
    
		List<Job> GetJobs();
		Job GetJobById(Guid selectedJobId);
	
		List<Job> getByTitle(string title);
	}
}
