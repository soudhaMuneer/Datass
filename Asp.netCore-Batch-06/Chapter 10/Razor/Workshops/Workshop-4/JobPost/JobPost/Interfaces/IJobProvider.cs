
using JobPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPost.Interfaces
{
    public interface IJobProvider
    {
        bool PostJob(Job job);
        List<Job> GetJobs();
      
    }
}
