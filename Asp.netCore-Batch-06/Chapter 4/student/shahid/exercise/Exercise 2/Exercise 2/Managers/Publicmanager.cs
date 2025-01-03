using Exercise_2.Enums;
using System;
using Exercise_2.Expectations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Exercise_2.Models;
using Exercise_2.Repository;

namespace Exercise_2.Managers
{
    public class Publicmanager : IMenu
    {
        User LoggedinUser =new User();
        UserRepository UserRepository = new UserRepository();
        bool Isloggedin = false;
        IMenu menu;

        public void Displaymenu()
        {
            showmainmenu();

        }

        void showmainmenu()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Enter your choice\n1.Login\n2.Register\n3.Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Login");
                        login();
                        menu.Displaymenu();
                        break;
                    case "2":
                        Register();
                        Console.WriteLine("register");
                        break;
                    default:
                        Console.WriteLine("enter valid");
                        break;
                }
                
            }
        }
        void Register()
        {
            try
            {
                User newJobSeeker = new User();

                Console.WriteLine("Please enter your first name:");
                newJobSeeker.FirstName = Console.ReadLine();

                Console.WriteLine("Please enter your last name:");
                newJobSeeker.LastName = Console.ReadLine();

                //  Console.WriteLine("Please enter your email address:");
                newJobSeeker.Email = GetEmail();

                newJobSeeker.Phone = GetPhoneNumber();


                Console.WriteLine("Please enter a password:");
                newJobSeeker.Password = Console.ReadLine();
                UserRepository.register(newJobSeeker);
                // Register(newJobSeeker);

                Console.WriteLine("Registration successful");
            }
            catch (UserAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message + "\n"); }

        }
        void login()
        {
            Console.WriteLine("Enter your email");
            string email = GetEmail();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            LoggedinUser = UserRepository.WhosLogingin(email, password);
            if(LoggedinUser != null)
            {
                //login success
                Isloggedin = true;
                Console.WriteLine("You have logged in successfully");
                if(LoggedinUser.Role == Roles.JobProvider)
                {
                    //it is job provider
                    menu = new Providemanager(LoggedinUser);
                }
                else if(LoggedinUser.Role == Roles.JobSeeker) 
                {
                    menu = new Seekermanager(LoggedinUser);
                }
            }
            else
            {
                //failed
                Console.WriteLine("Loggedin failed please try again");
            }

        }
        private string GetEmail()
        {
            try
            {
                Console.WriteLine("Please enter your email address:");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("email was not in correct format :" + email);
                return email;
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again...");
                return GetEmail();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
        }
        private long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your phone number:");
                long Phone = long.Parse(Console.ReadLine());
                return Phone;
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhoneNumber();
            }
        }
    }
}
