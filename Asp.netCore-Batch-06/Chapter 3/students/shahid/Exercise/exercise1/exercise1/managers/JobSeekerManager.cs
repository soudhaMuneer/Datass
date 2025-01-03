using exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1.managers
{
    public class JobSeekerManager
    {
        public JobSeeker[] jobseeker = new JobSeeker[10];//arry to store regestered job seekers
        public JobSeeker loggedinseeker = new JobSeeker();
        public JobManager jobManager= new JobManager();
        public int regjobseekercount = 0;

        public void registerjobseeker()
        {
            JobSeeker regJobseeker = new JobSeeker();
            Console.WriteLine("============================\nRegistering New User\n============================");
            Console.WriteLine("Please enter your first name:");
            regJobseeker.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            regJobseeker.LastName = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");
            regJobseeker.Email = Console.ReadLine();

            Console.WriteLine("Please enter your phone number:");
            regJobseeker.Phone = Console.ReadLine();

            Console.WriteLine("Please enter a password:");
            regJobseeker.Password = Console.ReadLine();



            jobseeker[regjobseekercount] = regJobseeker;
            regjobseekercount++;

            Console.WriteLine("*******************Registration successful*********************");
            ShowMainMenu();


        }
        public void loginjobseeker()
        {
            bool succ = true;
            JobSeeker enteredDetails = new JobSeeker();
            Console.WriteLine("Enter your Email");
            enteredDetails.Email = Console.ReadLine();
            Console.WriteLine("Enter your password");
            enteredDetails.Password = Console.ReadLine();
            foreach(JobSeeker seeker in jobseeker)
            {
                if(seeker != null && enteredDetails.Email == seeker.Email && enteredDetails.Password == seeker.Password)
                {
                    Console.WriteLine("login succesfull");
                    loggedinseeker = seeker;
                    succ = false;
                    showJobseekerMenu();
                }
            }
            if(succ)
            {
                Console.WriteLine("login not succesfull");
                ShowMainMenu();
            }
        }
        public void Applyjob()
        {
            Console.WriteLine("Enter your choice\n1.addJob\n2.Show Appliedjob");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("---------------ADDING JOB---------------");
                    Job Appliedjob = new Job();
                    Console.WriteLine("Enter title of the job");
                    Appliedjob.Title = Console.ReadLine();
                    Console.WriteLine("Enter Company of the job");
                    Appliedjob.Company = Console.ReadLine();
                    Console.WriteLine("Enter Location of the job");
                    Appliedjob.Location = Console.ReadLine();
                    Console.WriteLine("Enter SalaryRange of the job");
                    Appliedjob.SalaryRange = Console.ReadLine();
                    Console.WriteLine("Enter Jobtype of the job");
                    Appliedjob.JobType = Console.ReadLine();
                    loggedinseeker.addAppliedJob(Appliedjob);
                    break;
                case "2":
                    loggedinseeker.GetAppliedjobs();
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    Applyjob();
                    break;
            }

        

        }
        public void Savejob()
        {
            Console.WriteLine("Enter your choice\n1.Savejob\n2.Show Saved job");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("---------------SAVEING JOB---------------");
                    Job Savedjob = new Job();
                    Console.WriteLine("Enter title of the job");
                    Savedjob.Title = Console.ReadLine();
                    Console.WriteLine("Enter Company of the job");
                    Savedjob.Company = Console.ReadLine();
                    Console.WriteLine("Enter Location of the job");
                    Savedjob.Location = Console.ReadLine();
                    Console.WriteLine("Enter SalaryRange of the job");
                    Savedjob.SalaryRange = Console.ReadLine();
                    Console.WriteLine("Enter Jobtype of the job");
                    Savedjob.JobType = Console.ReadLine();
                    loggedinseeker.Addsavedjobs(Savedjob);
                    break;
                case "2":
                    loggedinseeker.GetSavedjob();
                    break;
                default:
                    Console.WriteLine("Enter a valid input");
                    Savejob();
                    break;
            }


        }
        public void showJobseekerMenu()
        {
            
            while(true)
            {
                
                Console.WriteLine("==========================");
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1.Apply job");
                Console.WriteLine("2.Save job");
                Console.WriteLine("3.View profile");
                Console.WriteLine("4.Logout");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": 
                        Console.WriteLine("working");
                        Applyjob();
                        break;
                    case "2":
                        Console.WriteLine("working");
                        Savejob();
                        break;
                    case "3":
                        Console.WriteLine("working");
                        ViewProfile();
                        break;
                    case "4":
                        Console.WriteLine("working");
                        LogOut();
                        break;
                        default:
                        Console.WriteLine("enter a valid input");
                        break;
                }
            }
        }
        public void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the job portal!");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");

            string choice = Console.ReadLine();
            
                switch (choice)
                {
                    case "1":
                        registerjobseeker();
                        break;
                    case "2":
                        loginjobseeker();
                        break;
                        default:
                        Console.WriteLine("-------------------------enter valid input-------------------------");
                        break;
                }
            }

        }
        public void LogOut()
        {
            Console.WriteLine("-------------------------logging out-------------------------");
            ShowMainMenu();
        }
        public void ViewProfile()
        {
            Console.WriteLine("---------------MY PROFILE----------------");
            Console.WriteLine("First Name: {0}", loggedinseeker.FirstName);
            Console.WriteLine("Last Name: {0}",loggedinseeker.LastName);
            Console.WriteLine("Email: {0}",loggedinseeker.Email);
            Console.WriteLine("Phone: {0} ",loggedinseeker.Phone);
            Console.WriteLine("Location: {0}", loggedinseeker.Location);
            Console.WriteLine("AboutMe: {0}",loggedinseeker.AboutMe);
            Console.WriteLine("ExperienceLevel: {0}",loggedinseeker.ExperienceLevel);
            Console.WriteLine("\n");

        }

    }
    
}
