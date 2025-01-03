

using JobPost.Enums;
using JobPost.Interfaces;
using JobPost.Models;
using JobPost.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.Managers
{
    public class JobPortal : IJobProvider
    {
        JobRepository JobRepository = JobRepository.Instance;

       
        public bool PostJob(Job job)
        {
            JobRepository.PostJob(job);
            return true;

        }

        public List<Job> GetJobs()
        {
            return JobRepository.GetJobs();
        }

      
    }
}
