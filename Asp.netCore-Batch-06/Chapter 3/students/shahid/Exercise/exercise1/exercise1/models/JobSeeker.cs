using exercise1.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.Models
{
    public class JobSeeker
    {
        public Job[] Appliedjob = new Job[10];
        public Job[] Savedjob = new Job[10];
        public int savedjobcount = 0;
        public int Appliedjobcount = 0;
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string AboutMe { get; set; }
        public string Qualification { get; set; }
        public Experiencelevel ExperienceLevel { get; set; }
        public string Password { get; set; }

        public void addAppliedJob(Job job)
        {
            if(Appliedjobcount < 10 )
            {
                Appliedjob[Appliedjobcount] = job;
                Appliedjobcount++;
                Console.WriteLine("saved succesfully");
            }
            else
            {
                Console.WriteLine("Only 10 jobs --maximum reached");
            }
        }
        public void GetAppliedjobs()
        {
            foreach(Job job in Appliedjob)
            {
                if (job != null)
                {
                    Console.WriteLine(job.Title);
                }
            }
            
        }
    

        //saved job
        public void Addsavedjobs(Job job)
        {
            if(savedjobcount < 10 )
            {
                Savedjob[savedjobcount] = job;
                savedjobcount++;
                Console.WriteLine("saved succesfully");
            }
            else
            {
                Console.WriteLine("maximum size reached");
            }
        }

        public Job[] GetSavedjob()
        {
             return Savedjob;
        }
    }
}
