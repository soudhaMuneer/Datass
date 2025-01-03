using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IJobRepository
    {
       
	
		Job GetJobById(Guid selectedJobId);
        List<Job> GetJobs();
    }
}
