// See https://aka.ms/new-console-template for more information
using HireMeNow.Managers;
using HireMeNow.Models;
namespace HireMeNow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JobSeekerManager manager = new JobSeekerManager();
           
            while (true)
            {
                Console.WriteLine("WELCOME TO HIRE ME NOW!!!!!");
                manager.ShowMainMenu();
               /* Console.WriteLine("1.Registration");
                Console.WriteLine("2.Login");
                Console.WriteLine("3.Exit");
                string choice=Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("-------REGISTRATION------");
                       /* Console.WriteLine("Enter your first name:");
                        string FirstName= Console.ReadLine();
                        Console.WriteLine("Enter your last name:");
                        string LastName = Console.ReadLine();
                        Console.WriteLine("Enter your email:");
                        string Email = Console.ReadLine();
                        Console.WriteLine("Enter your phone number:");
                        string Phone= Console.ReadLine();
                        Console.WriteLine("Enter your location:");
                        string Location = Console.ReadLine();
                        Console.WriteLine("Enter about yourself:");
                        string AboutMe = Console.ReadLine();
                        Console.WriteLine("Enter your qualification:");
                        string Qualification = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        string Password = Console.ReadLine();

                        manager.RegisterJobSeeker();
                        Console.WriteLine("Registration successfull");
                        break;

                        case "2":
                        Console.WriteLine("---------LOGIN--------");
                       /* Console.WriteLine("Enter your email");
                        string EmailLogin = Console.ReadLine();
                        Console.WriteLine("Enter your password:");
                        string PasswordLogin = Console.ReadLine();
                        manager.LoginJobSeeker();
                        break;

                        case "3":
                        Console.WriteLine("logout");
                        return;
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }*/
                


            }
            Console.ReadLine();
        }

    }
}
