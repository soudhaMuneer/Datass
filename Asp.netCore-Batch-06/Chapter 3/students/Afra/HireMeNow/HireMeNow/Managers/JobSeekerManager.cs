using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireMeNow.Models;

namespace HireMeNow.Managers
{
    public class JobSeekerManager
    {
        public static JobSeeker[] jobseeker=new JobSeeker[10];
        public JobManager jobManager=new JobManager();
        int JobSeekerCount = 0;
        public JobSeeker LoggedInJobSeeker = new JobSeeker();
      
        public void RegisterJobSeeker()
        { 
            JobSeeker newJobSeeker= new JobSeeker();
            Console.WriteLine("Enter your first name:");
            newJobSeeker.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            newJobSeeker.LastName = Console.ReadLine();
            Console.WriteLine("Enter your email");
            newJobSeeker.Email = Console.ReadLine();
            Console.WriteLine("Enter your phone:");
            newJobSeeker.Phone = Console.ReadLine();
            Console.WriteLine("Enter your location:");
            newJobSeeker.Location = Console.ReadLine();
            Console.WriteLine("Enter about yourself:");
            newJobSeeker.AboutMe = Console.ReadLine();
            Console.WriteLine("Enter your Qualification:");
            newJobSeeker.Qualification = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            newJobSeeker.Password = Console.ReadLine();

            jobseeker[JobSeekerCount] = newJobSeeker;
            JobSeekerCount++;

            Console.WriteLine("Registration successfull");
        }

        public bool LoginJobSeeker()
        {
            Console.WriteLine("Enter your email:");
            string email= Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password= Console.ReadLine();
            bool loginSuccessfull= false;
            foreach (JobSeeker seeker in jobseeker)
            { 
                if(seeker!=null && seeker.Email==email && seeker.Password==password)
                {
                    LoggedInJobSeeker = seeker;
                    loginSuccessfull = true;
                    break;
                }
            }
            return loginSuccessfull;
      

        }
        public void ShowJobSeekerMenu()
        {
            JobManager manager = new JobManager();
            Console.WriteLine("1.My Profile");
            Console.WriteLine("2.Logout");
            string choice= Console.ReadLine();
            switch(choice)
            {
                case "1":ViewProfile();
                       manager.ShowJobSeekerMenu1();
                        break;
                
               
                case "2":
                    logout();
                    break;
                default: Console.WriteLine("wrong choice..try again !!!");
                         ShowJobSeekerMenu();
                         break;
            }
        }
        public void ViewProfile()
        {
            Console.WriteLine("MY PROFILE");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"First Name: { LoggedInJobSeeker.FirstName}");
            Console.WriteLine($"Last Name: {LoggedInJobSeeker.LastName}");
            Console.WriteLine($"Email: {LoggedInJobSeeker.Email}");
            Console.WriteLine($"Password: {LoggedInJobSeeker.Password}");
            Console.WriteLine($"Location: {LoggedInJobSeeker.Location}");
            Console.WriteLine($"About me: {LoggedInJobSeeker.AboutMe}");
            Console.WriteLine($"Qualification: {LoggedInJobSeeker.Qualification}");
            Console.WriteLine($"Experience Level: {LoggedInJobSeeker.Experience}");
            Console.WriteLine("---------------------------------------------------");

        }

        public void logout()
        {
            LoggedInJobSeeker = new JobSeeker();
            Console.WriteLine("Logged out successfully!");
            ShowMainMenu();
        }
        public void ShowMainMenu()
        {
            Console.WriteLine("WELCOME TO HIRE ME NOW JOB PORTAL");
            Console.WriteLine("1.Register");
            Console.WriteLine("2.Login");
            string choice=Console.ReadLine();
            switch(choice)
            {
                case "1":RegisterJobSeeker();
                    break;
                case "2":
                    bool login=LoginJobSeeker();
                    if (login)
                    {
                        Console.WriteLine("Welcome  " + LoggedInJobSeeker.FirstName + LoggedInJobSeeker.LastName);
                        ShowJobSeekerMenu();
                    }
                    else
                    {
                        Console.WriteLine("login failed....try again!!!");
                        ShowJobSeekerMenu();
                    }
                    break;
                case "3":
                    Console.WriteLine("Invalid Choice");
                    ShowMainMenu();
                    break;

            }
        }
    }
}
