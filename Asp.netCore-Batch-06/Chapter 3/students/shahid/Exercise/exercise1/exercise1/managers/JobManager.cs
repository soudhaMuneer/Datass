using exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.managers
{
    public class JobManager
    {
        public Job[] Jobs = new Job[10];

        public void ListJobs()
        {
            foreach(Job job in Jobs)
            {
                Console.WriteLine(job.Title);
            }
        }

        public void PrintJobs(Job[] jobs)
        {
            //ntha veend nn doubt ind
            foreach (Job job in Jobs)
            {
                Console.WriteLine("======================");
                Console.WriteLine(job.Title);
                Console.WriteLine(job.Experiencelevel);
                Console.WriteLine(job.Location);
                Console.WriteLine(job.SalaryRange);
            }
        }

        public Job GetJobByid(int jobid)
        {
            Job ob = new Job();
            foreach(Job item in Jobs)
            {
                if(item.Id == jobid)
                {
                    Console.WriteLine("found id");
                    ob = item;
                   
                }
                else
                {
                    Console.WriteLine("id not found");
                }
            }
            return ob;

            
        }
    }
}
