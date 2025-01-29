using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IJobService
    {
  
        public List<Job> GetJobs();
        public Job getJobById(Guid selectedJobId);

		List<Job> getByTitle(string title);
		
	}
}
