using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Interface;
using WorkShop1.Models;

namespace WorkShop1.Manager
{
    public class JobManager:IJobProvider
    {
        private List<Jobs> jobs = new List<Jobs>();
        public void PostJob(Jobs job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Jobs> GetJobs()
        {
            return jobs;
        }
    }
}
