using HireMeNow_MVC_Application.Models;

namespace HireMeNow_MVC_Application.Interfaces
{
    public interface IJobRepository
    {
        
        List<Job> GetJobs();
		Job GetJobById(Guid selectedJobId);
	
		
	
	}
}
