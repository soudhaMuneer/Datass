﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop3.Models;

namespace workshop3.Manager
{
    public class Jobmanager
    {
        Jobs[] jobs = new Jobs[3]
        {
            new Jobs{ Id=1,Title="developer",Description="python developer",  Salary="1000",  Location="kozhikode",  RequiredSkills="programming",  IsAvailable=true  },
             new Jobs{Id=2, Title="developer",Description="Java developer",  Salary="1000",  Location="kozhikode",  RequiredSkills="programming",  IsAvailable=true  },
              new Jobs{ Id=3,Title="developer",Description=" C# developer",  Salary="1000",  Location="kozhikode",  RequiredSkills="programming",  IsAvailable=true  }
        };

        public void ListJobs()
        {
            Console.WriteLine("Jobs available: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20}    ", "JobId", "Title", "Discription", "Salary", "Location", "IsAvailable");

            foreach (Jobs job in jobs)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20}    ", job.Id, job.Title, job.Description, job.Salary, job.Location, job.IsAvailable);
            }

            Console.WriteLine("\n");
        }
    }
}
