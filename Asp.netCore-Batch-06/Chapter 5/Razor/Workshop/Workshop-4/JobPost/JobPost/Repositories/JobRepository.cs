
using JobPost.Interfaces;
using JobPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.Repositories
{
    public class JobRepository : IJobProvider
    {
        private static JobRepository instance = null;
        private static readonly object padlock = new object();

         JobRepository() { }
        public static JobRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new JobRepository();
                    }
                    return instance;
                }
            }
        }

        private List<Job> jobs = new List<Job> { new Job(1,"Developer", "Software Developer", "Kunnamkulam", "onsite", "100000", "Tcs"),new Job(2 ,"Senior Developer", "Software Developer", "Kochi", "onsite", "100000", "Tcs") };

        public bool PostJob(Job job)
        {
            job.Id = jobs.Count+1;
            jobs.Add(job);   
            return true;
        }
        public List<Job> GetJobs()
        {
            return jobs;
        }
        public Job getJobById(int id)
        {
           return jobs.FirstOrDefault(e=>e.Id==id);
        }

       

      
    }
}
