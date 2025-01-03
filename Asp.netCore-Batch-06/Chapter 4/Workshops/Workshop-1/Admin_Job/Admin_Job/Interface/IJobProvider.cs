﻿
using Admin_Job.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Interfaces
{
    public interface IJobProvider
    {
        void PostJob(Job job);
        List<Job> GetJobs();
    
    }
}
