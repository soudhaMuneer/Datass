using Admin_Portal.Interface;
using Admin_Portal.Model;
using Admin_Portal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Services
{
    public class Admin:IMenu
    {
        public static JobRepository JobRepository = new JobRepository();
        public static UserRepository UserRepository = new UserRepository();
        Jobportal Jobportal = new Jobportal();
        public User logeduser;
        public Lists joblist = new Lists();
        public void Menu()
        {
            ShowDisplay();
        }
        public void ShowDisplay()
        {
            Console.WriteLine("1.New Registrations\n2.List All Jobs\n3.Logout");
            Console.WriteLine();
            Console.WriteLine("Choose Any Options");
            string choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    List<User> users = UserRepository.Getuser();
                    if (users != null)
                    {
                        Console.WriteLine("Available Registers: \n");
                        joblist.Print(users);
                        Console.WriteLine();
                        ShowDisplay();
                    }
                    else
                    {
                        Console.WriteLine("No Available Registers Yet: \n");

                    }
                   
                    break;
                case "2":
                    List<Job> jobs = JobRepository.Getjob();
                    joblist.Print(jobs);
                    Console.WriteLine();
                    ShowDisplay();
                    break;
                case "3":
                    
                    Console.WriteLine("Logged out successfully!");
                    Console.WriteLine("\nWelcome Back ....\n");
                    Jobportal.Menu();
                    
                    break;
            }
        }
    }
}
