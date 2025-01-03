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
    public class Jobseeker
    {
        public static JobRepository JobRepository = new JobRepository();
        public static UserRepository UserRepository = new UserRepository();
        Jobportal Jobportal = new Jobportal();
        public User logeduser;
        public Lists joblist=new Lists();
        public Jobseeker(User log) 
        {
            logeduser = log;
            ShowDisplay();
        }
        public Jobseeker() { }
        //public void Menu()
        //{
            
        //}
        public void ShowDisplay()
        {
            Console.WriteLine("1.List All Job\n2.My Profile\n3.Logout");
            Console.WriteLine();
            Console.WriteLine("Choose Any Options");
            string choose = Console.ReadLine();
            switch(choose)
            {
                case "1":
                    List<Job> jobs= JobRepository.Getjob();
                    joblist.Print(jobs);
                    Console.WriteLine();
                    ShowDisplay();
                    break;
                case "2":
                    List<User> users= UserRepository.Getuser();
                    joblist.Print(users);
                    Console.WriteLine();
                    ShowDisplay();
                    break;
                case "3":
                    Jobportal.Menu();
                    Console.WriteLine("Logged out successfully!");
                    break;
            }
        }
    }
}
