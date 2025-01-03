using RazorWorkshop4.Interfaces;
using RazorWorkshop4.Models;

namespace RazorWorkshop4.JobRepositories
{
    public class JobRepository:IJobProvider
    {
        private static JobRepository Instance = new JobRepository();

        public static List<Job> jobs = new List<Job>
        {
            new Job(1,"Software Engineer","Master's in cs","Dubai","4500AED","onsite","Microsoft",10,15),
            new Job(2,"CA","Master's in Accounting","Abudhabi","5000AED","onsite","Hitton",5,10)
        };

        public JobRepository() { }
        public bool PostJob(Job job)
        {
            _ = job.Id == jobs.Count + 1;
            jobs.Add(job);
            return true;

        }

        public List<Job> GetJobs()
        {
            return jobs;
        }

        public Job getJobById(int id)
        {
            return jobs.FirstOrDefault(e => e.Id == id);
        }
        


    }
}
