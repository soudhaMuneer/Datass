using HireMeNow_MVC_Application.Models;

namespace HireMeNow_MVC_Application.Interfaces
{
    public interface IJobService
    {
       
        public List<Job> GetJobs();
        public Job getJobById(Guid selectedJobId);
		
	}
}
