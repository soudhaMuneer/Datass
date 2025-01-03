using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using HireMeNow.Enum;
using HireMeNow.Models;

namespace HireMeNow.Managers
{
    public class JobManager
    {
        public static int count = 0;
        public static JobSeeker seeker = new JobSeeker();
        public static Job[] jobs = new Job[10];
        public static JobSeekerManager seekerManager = new JobSeekerManager();

        public void AddJob()
        {
            Console.WriteLine("number of jobs you want to add");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter job id {0}", i + 1);
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Job title {0}", i + 1);
                string Title = Console.ReadLine();
                Console.WriteLine("Enter experience level");
                ExperienceLevel Level = new ExperienceLevel();
                Console.WriteLine("Enter company name {0}", i + 1);
                string Company = Console.ReadLine();
                Console.WriteLine("Enter Job location {0}", i + 1);
                string Location = Console.ReadLine();
                Console.WriteLine("Enter Job salary {0}", i + 1);
                string SalaryRange = Console.ReadLine();
                Console.WriteLine("Enter Job type {0}", i + 1);
                string JobType = Console.ReadLine();

                Job newjob = new Job(Id, Title,Level, Company, Location, SalaryRange, JobType);
                jobs[i] = newjob;
                count++;
            }
        }
        public void ListJob()
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("---------List job-------");
                    Console.WriteLine(jobs[i].Title);
                    Console.WriteLine(jobs[i].Company);
                    Console.WriteLine(jobs[i].Location);
                    Console.WriteLine(jobs[i].SalaryRange);
                    Console.WriteLine(jobs[i].JobType);
                }
            }
            Console.WriteLine("1.applied jobs");
            Console.WriteLine("2.saved jobs");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    seeker.getAppliedJob();
                    break;
                case 2:
                    seeker.getSavedJob();
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }
        public void ApplyJob()
        {
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("-------Apply job------");
                    Console.WriteLine(jobs[i].Title);
                    Console.WriteLine(jobs[i].Company);
                    Console.WriteLine(jobs[i].Location);
                    Console.WriteLine(jobs[i].SalaryRange);
                    Console.WriteLine(jobs[i].JobType);
                }
            }
            Console.WriteLine("Apply job with id:");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jobs.Length; i++)
            {
                if (jobs[i].Id == input)
                {
                    seeker.addAppliedJob(jobs[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("no job found");
                }
            }
        }
            public void GetJobById(int JobId)
            {
                Job job = new Job();
                foreach (Job job1 in jobs)
                {
                    if (job1.Id == JobId)
                    {
                        job = job1;
                        Console.WriteLine(job.Title);
                        Console.WriteLine(job.Company);
                        Console.WriteLine(job.Location);
                        Console.WriteLine(job.SalaryRange);
                        Console.WriteLine(job.JobType);
                        break;
                    }
                }

            }
            public void SaveJob()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(jobs[i].Title);
                }
                Console.WriteLine("save job with id:");
                int input = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < jobs.Length; i++)
                {
                    if (jobs[i].Id == input)
                    {
                        seeker.addSavedJob(jobs[i]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("not found");
                    }
                }
            }
            public void ShowJobSeekerMenu1()
            {
                string input = "0";
                while (input != "5")
                {
                    Console.WriteLine("1.Add job\n");
                    Console.WriteLine("2.List job\n");
                    Console.WriteLine("3.Apply job\n");
                    Console.WriteLine("4.Save job\n");
                    Console.WriteLine("5.Logout\n");


                    Console.WriteLine("Choose your choice");
                    string inp = Console.ReadLine();
                    switch (inp)
                    {
                        case "1":
                            AddJob();
                            break;
                        case "2":
                            ListJob();
                            break;
                        case "3":
                            ApplyJob();
                            break;
                        case "4":
                            SaveJob();
                            break;
                        
                        case "5":
                            Console.WriteLine("Exit");
                            break;

                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }










        }
    }


