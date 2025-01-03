using HireMeNow_BlazorApp.Dtos;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using HireMeNow_BlazorApp.Repositories;

namespace HireMeNow_BlazorApp.Services
{
    public class JobService : IJobService
    {
        IJobRepository _jobRepository;
        public JobService(IJobRepository jobRepository )
        {
            _jobRepository=jobRepository;
        }

	
			
		public void DeleteItemById(Guid id)
		{
			_jobRepository.DeleteById(id);

		}

		public List<Job> getByTitle(string title)
		{
			
				return _jobRepository.getByTitle(title);
		

		}

		public Job getJobById(Guid selectedJobId)
		{
			return _jobRepository.GetJobById(selectedJobId);
		}

		public List<Job> GetJobs()
        {
           return _jobRepository.GetJobs();
        }

        public List<Job> GetJobsByCompany(Guid cmpId)
        {
            return _jobRepository.GetJobsByCompany(cmpId);
        }

        public Job PostJob(Job job)
        {
			return _jobRepository.PostJob(job);
        }

		public Job Update(Job job)
		{
			var updatedjob = _jobRepository.Update(job);
			return updatedjob;
		}
	}
}
