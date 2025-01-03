

using Mvc_HireMeNow.Models;

namespace Mvc_HireMeNow.Interfaces
{
    public interface IJobRepository
    {
		Job GetJobById(Guid selectedJobId);
		
		List<Job> GetJobs();
		
	}
}
