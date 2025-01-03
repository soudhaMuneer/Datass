using Exercise3.Enums;
using Exercise3.Interface;
using Exercise3.Model;
using Exercise3.Repository;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Manager
{
    public class JobManager : IJobProvide, IMenu, IApplication, IInterview
    {
        IApplication apply ;
        public List<Jobs> jobslist = new List<Jobs>();
        public List<Application> applications = new List<Application>();
        UserRepository userRepository = new UserRepository();
        public List<Interview> interviews = new List<Interview>();
        private User loggedUser;
        public Lists display = new Lists();
        Lists list = new Lists();
        private Roles role;
        public Lists toprint ;

        public JobManager(Roles role)
        {
            this.role = role;
        }

        public void DisplayMenu()
        {
            ShowProviderMenu();
        }

        private void ShowProviderMenu()
        {
            Console.WriteLine("1. Post Job");
            Console.WriteLine("2. List All Jobs");
            Console.WriteLine("3. Show Applications");
            Console.WriteLine("4. Schedule Interview");
            Console.WriteLine("5. List Scheduled Interviews");
            Console.WriteLine("6. Logout");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PostJob();
                    ShowProviderMenu();
                    break;

                case "2":
                    GetJobs();
                    ShowProviderMenu();
                    break;

                case "3":
                    //GetApplications();
                    List<Application> applications = userRepository.GetApplications();  
                    list.Print(applications);
                    ShowProviderMenu();
                    break;
                case "4":
                    ScheduleInterview();
                    ShowProviderMenu();
                    break;
                case "5":
                    GetInterviews();
                    ShowProviderMenu();
                    break;
                case "6":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowProviderMenu();
                    break;
            }
        }

        public void PostJob()
        {
            
            Console.Write("Enter job Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter job description: ");
            string description = Console.ReadLine();
            Console.Write("Enter job location: ");
            string location = Console.ReadLine();
            Console.Write("Enter job Type: ");
            string type = Console.ReadLine();
            Console.Write("Enter job salary: ");
            string salary = Console.ReadLine();
            Console.Write("Enter job company: ");
            string company = Console.ReadLine();

            Jobs newjob = new Jobs(title, description, location, type, salary, company);
            jobslist.Add(newjob);
            Console.WriteLine("Job posted successfully!");
        }

        public void Print(Jobs job)
        {
            Console.WriteLine($"Title: {job.Title}");
            Console.WriteLine($"Description: {job.Description}");
            Console.WriteLine($"Location: {job.Location}");
            Console.WriteLine($"Type: {job.Type}");
            Console.WriteLine($"Salary: {job.Salary}");
            Console.WriteLine($"Company: {job.Company}");
            Console.WriteLine();
        }

        public List<Jobs> GetJobs()
        {
            if (jobslist.Count == 0)
            {
                Console.WriteLine("No jobs available.");
            }
            else
            {
                foreach (Jobs job in jobslist)
                {
                    Print(job);
                }
            }
            return jobslist;
        }
        
        
        public void ScheduleInterview()
        {
            Interview intrv = new Interview();

            Console.WriteLine("Enter company");
            intrv.Company = Console.ReadLine();
            Console.WriteLine("Enter Job");
            intrv.Job = Console.ReadLine();
            Console.WriteLine("Enter Date (YYYY-MM-DD): ");
            intrv.Date = Console.ReadLine();
            Console.WriteLine("Enter location");
            intrv.Location = Console.ReadLine();
            Console.WriteLine("Enter time (HH:MM AM/PM): ");

            intrv.Time = Console.ReadLine();
            interviews.Add(intrv);
            Console.WriteLine("Interview scheduled successfully!");
        }
        public List<Interview> GetInterviews()
        {
            if (interviews.Count == 0)
            {
                Console.WriteLine("No interviews scheduled.");
            }
            toprint.Print(interviews);
            return interviews;
        }

        public void Print(Interview intrv)
        {
            Console.WriteLine($"Company: {intrv.Company}");
            Console.WriteLine($"Job: {intrv.Job}");
            Console.WriteLine($"Date: {intrv.Date}");
            Console.WriteLine($"Location: {intrv.Location}");
            Console.WriteLine($"Time: {intrv.Time}");
            Console.WriteLine();
        }

        private void Logout()
        {
            loggedUser = null;
            Console.WriteLine("Logged out successfully.");
        }

        public List<Application> GetApplications()
        {
            return apply.GetApplications();
        }
    }                                                       
}
