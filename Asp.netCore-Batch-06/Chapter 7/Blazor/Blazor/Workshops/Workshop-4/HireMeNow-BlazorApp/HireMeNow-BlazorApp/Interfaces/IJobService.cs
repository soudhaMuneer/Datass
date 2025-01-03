using HireMeNow_BlazorApp.Dtos;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
    public interface IJobService
    {
        public Job PostJob(Job job);
        public List<Job> GetJobs();
        public List<Job> GetJobsByCompany(Guid companyId);
        public Job getJobById(Guid selectedJobId);
		void DeleteItemById(Guid id);
		Job Update(Job job);
		List<Job> getByTitle(string title);
		
	}
}
