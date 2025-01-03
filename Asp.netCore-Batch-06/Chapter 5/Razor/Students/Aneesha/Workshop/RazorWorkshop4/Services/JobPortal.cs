using RazorWorkshop4.Interfaces;
using RazorWorkshop4.JobRepositories;
using RazorWorkshop4.Models;

namespace RazorWorkshop4.Services
{
    public class JobPortal : IJobProvider
    {
        JobRepository jbRepo = new JobRepository();

        public bool PostJob(Job job)
        {
            jbRepo.PostJob(job);
            return true;
        }
        public List<Job> GetJobs()
        { 
            return jbRepo.GetJobs();
        }
    }
}
