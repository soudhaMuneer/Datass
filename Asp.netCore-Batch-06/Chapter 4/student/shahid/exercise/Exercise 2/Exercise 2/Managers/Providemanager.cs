using Exercise_2.Enums;
using Exercise_2.Interfaces;
using Exercise_2.Models;
using Exercise_2.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Managers
{
    public class Providemanager : IMenu
    {
        User loggeduser;
        IJobProvider Jobs = new JobRepository();
        Lists list = new Lists();

        public Providemanager(User loggedinuser) 
        {
            loggeduser=loggedinuser;
        }

        public void Displaymenu()
        {
            ShowProviderMenu();
            //display menu for logged in 
        }
        private void ShowProviderMenu()
        {
            Console.WriteLine("1. Post a  job ");
            Console.WriteLine("2. List all Jobs ");
            Console.WriteLine("3. Logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Job title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Job description: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter Job location: ");
                    string location = Console.ReadLine();
                    Console.Write("Enter Job Type: ");
                    string type = Console.ReadLine();
                    Console.Write("Enter Job salary range: ");
                    string salary = (Console.ReadLine());
                    Console.Write("Enter Job company: ");
                    string company = (Console.ReadLine());
                    Job job = new Job(title, company, location, salary, type );
                    Jobs.PostJob(job);
                    Console.WriteLine("Job posted successfully.");
                    ShowProviderMenu();
                    break;
                case "2":
                    List<Job> jobs = Jobs.GetJobs();
                    list.Print(jobs);
                    ShowProviderMenu();
                    break;
                case "3":
                    Logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowProviderMenu();
                    break;
            }
        }
        public void Logout()
        {
            loggeduser = new User();
            Console.WriteLine("Logged out successfully!");

        }
    }
}
