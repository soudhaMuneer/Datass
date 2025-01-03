using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IJobService
    {
        public Job PostJob(Job job);
        public List<Job> GetJobs();
      
		
	}
}
