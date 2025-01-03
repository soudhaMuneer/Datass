using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;
using HireMeNowWebApi.Repositories;

namespace HireMeNowWebApi.Services
{
    public class JobService : IJobService
    {
        IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository )
        {
            _jobRepository=jobRepository;
        }

	
		

		

		public List<Job> GetJobs()
        {
           return _jobRepository.GetJobs();
        }

		

		public Job PostJob(Job job)
        {
			return _jobRepository.PostJob(job);
        }

		
	}
}
