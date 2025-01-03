using ConsoleApp4.Interface;
using ConsoleApp4.Repository;
using ConsoleApp4.Models;
using ConsoleApp4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Manager
{
    public class AdminManager:IMenu
    {
        IJobProvider Jobs= new JobManager();
        private User loggedUser;
        private UserRepository Admin=new UserRepository();
        private Lists Display = new Lists();
        public AdminManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            ShowAdminMenu();
        }
        public void ShowAdminMenu()
        {
            
            Console.WriteLine("1.List all Admins");
            Console.WriteLine("2.My Profile");
            Console.WriteLine("3.Post job");
            Console.WriteLine("4.List job");
            Console.WriteLine("5.Logout");
            Console.WriteLine("Enter your choice:");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    var users = Admin.getAll();
                    Display.Print(users);
                    ShowAdminMenu();
                    break;
                case 2:
                    ViewProfile();
                    ShowAdminMenu();
                    break;
                case 3:
                    Console.WriteLine("Enter Job Id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Job Title:");
                    string title=Console.ReadLine();
                    Console.WriteLine("Enter job description:");
                    string description=Console.ReadLine();
                    Console.WriteLine("Enter job location:");
                    string location=Console.ReadLine();
                    Console.WriteLine("Enter job type:");
                    string type=Console.ReadLine();
                    Console.WriteLine("Enter job salary:");
                    string salary=Console.ReadLine();
                    Console.WriteLine("Enter job company");
                    string company=Console.ReadLine();
                    Job job=new Job(id,title, description, location, type, salary,company);
                    Jobs.PostJob(job);
                    Console.WriteLine("Job posted successfully!!!");
                    ShowAdminMenu();
                    break;
                case 4:
                    List<Job> jobs=Jobs.GetJobs();
                    Display.Print(jobs);
                    ShowAdminMenu();
                    break;
                case 5:
                    logout();
                    break;
                default:
                    Console.WriteLine("Invalid choice....try again!!");
                    ShowAdminMenu();
                    break;
            }
        }
        public void ViewProfile()
        {
            User loggeduser=Admin.getLoggedUser();
            Console.WriteLine("---------My Profile---------");
            Console.WriteLine("First Name : " + loggedUser.FirstName);
            Console.WriteLine("Last name : " + loggedUser.LastName);
            Console.WriteLine("Email : " + loggedUser.Email);
            Console.WriteLine("Password : " + loggedUser.Password);
            Console.WriteLine("Phone : " + loggedUser.Phone);
           
        }

        public void logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out successfully!!!!!!!!!!");
        }
    }
}
