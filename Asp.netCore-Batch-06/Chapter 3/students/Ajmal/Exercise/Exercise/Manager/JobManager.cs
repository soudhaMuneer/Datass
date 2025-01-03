using Exercise.Enums;
using Exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Manager
{
    public class JobManager
    {
        public static int count = 0;
       public static JobSeeker seeker=new JobSeeker();
        public static  Job[] jobs = new Job[10];
       public static JobSeekerManager seekerManager = new JobSeekerManager();
        public void Addjob()
        {
            Console.WriteLine("how much");
            int inp = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < inp; i++)
            {
                Console.WriteLine("Enter Job Id {0}", i+1);
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Job Title {0}", i+1);
                string Title = Console.ReadLine();
                Console.WriteLine("Enter Job Experience Level {0}", i+1);
               
                Console.WriteLine("Enter Company Name {0}", i+1);
                string Company = Console.ReadLine();
                Console.WriteLine("Enter Job Location {0}", i+1);
                string Location = Console.ReadLine();
                Console.WriteLine("Enter Salary {0}", i+1);
                string SalaryRange = Console.ReadLine();
                Console.WriteLine("Enter Job Type {0}", i+1);
                string JobType = Console.ReadLine();

                Job newjob = new Job( Id,Title, Company, Location, SalaryRange, JobType);
                jobs[i] = newjob;
                count++;
            }


        }
//public Job[] Applyjob=new Job[100];
        public void Listjob()
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------------Job {0}----------------------------------------------------------------", i + 1);
                    Console.WriteLine("Job Title:- {0,-10} Job Company:- {0,-20}\nCompany Location:- {0,-10} Job Type:- {0,-20}\n Experience Level:- {0,-10} Salary:- {0,-20}", jobs[i].Title, jobs[i].Company, jobs[i].Location, jobs[i].JobType, jobs[i].SalaryRange);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

                }


            }
            Console.WriteLine("1. Show Applied Jobs \n2. Show Saved Jobs");
            int inp1= Convert.ToInt32(Console.ReadLine());
            switch (inp1)
            {
                case 1:seeker.getappliedJobs(); break;
                    case 2:seeker.GetsavedJobs();
                    break;
                default: Console.WriteLine("Invalid Option");
                 
                    break;
            }

        }

        public void Applyjob()
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("----------------------------------------------------------------Job {0}----------------------------------------------------------------", i + 1);
                    Console.WriteLine("Job Title:- {0,-10} Job Company:- {0,-20}\nCompany Location:- {0,-10} Job Type:- {0,-20}\n Experience Level:- {0,-10} Salary:- {0,-20}", jobs[i].Title, jobs[i].Company, jobs[i].Location, jobs[i].JobType, jobs[i].SalaryRange);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

                }


            }
            Console.Write("Apply Job with id :- ");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < jobs.Length; j++)
            {
                if (jobs[j].Id == inp1)
                {
                    seeker.addAppliedJob(jobs[j]);
                    break;
                }
                else
                {
                    Console.WriteLine("Null");
                }
            }

        }

       // public Job[] savejob = new Job[100];
       public void GetjobById(int jobId)
        {
            Job job = new Job();
            foreach (Job jobb in jobs)
            {
                if (jobb.Id == jobId)
                {
                    job = jobb;
                    Console.WriteLine("----------------------------------------------------------------Job {0}----------------------------------------------------------------", i + 1);
                    Console.WriteLine("Job Title:- {0,-10} Job Company:- {0,-20}\nCompany Location:- {0,-10} Job Type:- {0,-20}\n Experience Level:- {0,-10} Salary:- {0,-20}", job.Title, job.Company, job.Location, job.JobType, job.SalaryRange);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

                    break;
                }
                else
                {
                    Console.WriteLine("hai");
                }
            }
        }
        public void Savejob() {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("----------------------------------------------------------------Job {0}----------------------------------------------------------------", i);
                Console.WriteLine("Job Title:- " + jobs[i].Title);
            }
            Console.Write("Save Job with id :- ");
            int inp1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i].Id==inp1)
                {
                    seeker.addsavedJob(jobs[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("Null");
                }
            }
        }

        public void ShowJobseekermenu()
        {
            string? inp = "0";
            while (inp != "6")
            {
                Console.WriteLine("1.Add job\n");
                Console.WriteLine("2.List job\n");
                Console.WriteLine("3.Apply job\n");
                Console.WriteLine("4.Save job\n");
                Console.WriteLine("5.View Profile\n");
                Console.WriteLine("6.Logout\n");
                Console.WriteLine("7.Back to main menu\n");
                Console.WriteLine();
                Console.WriteLine("Choose any");
                inp = Console.ReadLine();
                switch (inp)
                {
                    case "1":
                        Addjob();
                        break;
                    case "2":
                        Listjob();
                        break;
                    case "3":
                        Applyjob();
                        break;
                    case "4":
                        Savejob();
                        break;
                    case "5":
                        seekerManager.Profile();
                        break;
                    case "6":
                        Console.WriteLine("Exit");
                        break;
                    case "7":
                        seekerManager.ShowMainmenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }


            }
        }
    }
}
