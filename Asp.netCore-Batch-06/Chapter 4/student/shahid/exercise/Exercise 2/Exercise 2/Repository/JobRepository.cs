using Exercise_2.Enums;
using Exercise_2.Interfaces;
using Exercise_2.Models;
using Exercise_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Repository
{
    internal class JobRepository:IJobProvider
    {
        public JobRepository()
        {

        }
        public List<Job> jobs = new List<Job>{
            new Job ( 1,"Software Engineer",Experiencelevel.Senior, "Acme Inc.","New York, NY","$100,000 - $150,000","Full Time" ),
            new Job ( 2,"Product Manager",Experiencelevel.MidLevel, "Globex Corp.","San Francisco, CA","$120,000 - $180,000", "Part Time" ),
            new Job ( 3,"Marketing Specialist",Experiencelevel.Fresher, "Hooli Enterprises","Seattle, WA", "$70,000 - $90,000","Intern" )
        };
        public List<Job> Appliedjobs = new List<Job> ();
        //  applied job
        public void Applyjob(Job job)
        {
            Appliedjobs.Add (job);
        }
        public List<Job> GetAppliedjob()
        {
            return Appliedjobs;
        }
        //saved job

        //postjob
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
