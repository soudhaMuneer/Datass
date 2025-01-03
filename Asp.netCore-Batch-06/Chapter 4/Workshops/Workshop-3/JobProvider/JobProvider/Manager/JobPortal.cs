﻿
using JobProvider.Interfaces;
using JobProvider.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProvider.Manager
{
    public class JobPortal:IJobProvider
    {
        private List<Job> jobs = new List<Job>();
        public void PostJob(Job job)
        {
            job.Id = jobs.Count;
            jobs.Add(job);
        }

        public List<Job> GetJobs()
        {
            return jobs;
        }
    }
}
