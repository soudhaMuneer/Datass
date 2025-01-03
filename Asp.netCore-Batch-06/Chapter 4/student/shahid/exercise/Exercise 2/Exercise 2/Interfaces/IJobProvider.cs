using Exercise_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Interfaces
{
    public interface IJobProvider
    {

        void PostJob(Job job);
        List<Job> GetJobs();
    }
}
