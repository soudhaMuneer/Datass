using Exercise3.Exceptions;
using Exercise3.Interface;
using Exercise3.Model;
using Exercise3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise3.Manager
{
    public class PublicManager:IMenu
    {
        UserRepository userRepository = new UserRepository();
        List<User> users = new List<User>();
        private User loggedUser = new User();
        private Lists display = new Lists();
        bool  isLoggedIn = false;
        public IMenu menu;
        

        public void DisplayMenu()
        {
            ShowUserMenu();
        }
        private void ShowUserMenu()
        {
            bool exitProgram = false;
            while(!exitProgram)
            {
                Console.WriteLine("Choose an Option");
                Console.WriteLine("1.Get all jobs");
                Console.WriteLine("2.Registration");
                Console.WriteLine("3.Login");
                Console.WriteLine("4.Exit");

                string choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                       var users = userRepository.GetAll();
                        display.Print(users);
                        break;
                    case "2":
                        Registration();
                        break;
                    case "3":
                        Login();
                        if (isLoggedIn)
                        {
                            menu.DisplayMenu();
                        }
                        break;
                    case "4":
                          exitProgram = true;
                        break;
                }
            }
        }
        public void Registration()
        {
            try
            {
                User NewProvider = new User();

                Console.WriteLine("Enter your Name :");
                NewProvider.Name = Console.ReadLine();

                Console.WriteLine("Enter your company name :");
                NewProvider.CompanyName = Console.ReadLine();

                NewProvider.Email = GetEmail();

                Console.WriteLine("Enter your password :");
                NewProvider.Password = Console.ReadLine();

                NewProvider.phoneNumber = GetPhoneNumber();

                userRepository.register(NewProvider);

                Console.WriteLine("Registration successful.");

            }
            catch(UserAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }

        public void Login()
        {
            try
            {
                string email = GetEmail();

                Console.WriteLine("Please enter password");
                string password = Console.ReadLine();
                loggedUser = userRepository.login(email, password);
                if (loggedUser != null)
                {
                    Console.WriteLine("Login successful");
                    isLoggedIn = true;
                    Console.WriteLine("Welcome " + loggedUser.Name);
                    if (loggedUser.Role == Enums.Roles.JobProvider)
                    {
                        menu = (IMenu)new JobManager(loggedUser.Role);
                    }
                }
                else
                {
                    Console.WriteLine("Login failed . please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public string GetEmail()
        { 

            try
            {
                Console.WriteLine("Enter a Email :");
                string email = Console.ReadLine();
                Regex regax = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regax.IsMatch(email))
                
                    throw new InvalidFormatException("email was not correct in format : " + email);
                    return email;
                
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("try again ....");
                return GetEmail();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
        }

        private string GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your phone number :");
                long Phone = long.Parse(Console.ReadLine());
                return Phone.ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine("Enter a valid phone number");
                return GetPhoneNumber();
            }
        }
    }
}
