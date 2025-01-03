using Exercise_2.Enums;
using Exercise_2.Interfaces;
using Exercise_2.Models;
using Exercise_2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Managers
{
    public class Seekermanager :IMenu
    {
        User loggedinuserr = new User();
        Lists list = new Lists();
        JobRepository Jobs = new JobRepository();
        
        public Seekermanager(User loggedinuser) 
        {
            loggedinuserr = loggedinuser;
        }
        public void Displaymenu()
        {
            //display menu for logged in 
            ShowJobSeekerMenu();
        }
        public void ShowJobSeekerMenu()
        {
             // Console.WriteLine("Welcome " + loggedinuserr.FirstName + "!");
            
            Console.WriteLine("1. List all jobs");
            Console.WriteLine("2. Saved jobs");
            Console.WriteLine("3. Applied jobs");
            Console.WriteLine("4. My profile");
            Console.WriteLine("5. Logout");


            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    
                    showJoboptions();
                    //jobs.ListJobs();
                    ShowJobSeekerMenu();
                    break;
                case "2":
                    //showsaved job
                    ShowJobSeekerMenu();
                    break;
                case "3":
                   // showAppliedjob();
                    break;
                case "4":
                    showMyprofile();
                    break;
                case "5":
                    // Logout();
                    break;


                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowJobSeekerMenu();
                    break;
            }

        }
        private void showMyprofile()
        {
            //show profile
            ShowJobSeekerMenu();
        }
        private void showJoboptions()
        {
            List<Job> jobs = Jobs.GetJobs();
            list.Print(jobs);

            Console.WriteLine("Choose By id");
            Console.WriteLine("1.Applyjob");
            Console.WriteLine("2.Save Job");
            Console.WriteLine("3.Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Job jobSelectedById = jobs.Contains<Job>();
                    Jobs.Applyjob(jobSelectedById);
                    Console.WriteLine("Applied");
                    break;
                case "2":
                    Console.WriteLine("save");
                    break;
                case "3":
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    showJoboptions();
                    break;
            }
        }
    }
}
