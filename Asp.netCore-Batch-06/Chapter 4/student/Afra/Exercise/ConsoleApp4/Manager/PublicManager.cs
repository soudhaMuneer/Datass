using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp4.Enums;
using ConsoleApp4.Expectation;
using ConsoleApp4.Interface;
using ConsoleApp4.Repository;
using ConsoleApp4.Models;

namespace ConsoleApp4.Manager
{
    public class PublicManager:IMenu
    {
        UserRepository userRepository = new UserRepository();
        public User LoggedUser = new User();
        bool isLogged = false;
        IMenu menu;

        public void DisplayMenu()
        {
            ShowUserMenu();
        }

        public void ShowUserMenu()
        {
            bool exitProgram = false;
            while(!exitProgram)
            {
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Exit");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        LoginAdmin();
                        if(isLogged)
                            menu.DisplayMenu();
                        break;
                    case 2:
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("invalid choice:");
                        ShowUserMenu();
                        break;
                }
            }
        }

        void LoginAdmin()
        {
            try
            {
                //Console.WriteLine("Please enter your email:");
                string email = GetEmail();

                Console.WriteLine("Please enter your password:");
                string password = Console.ReadLine();
                LoggedUser = userRepository.login(email, password);
                if (LoggedUser != null)
                {
                    Console.WriteLine("Login successful!");
                    isLogged = true;
                    Console.WriteLine("Welcome " + LoggedUser.FirstName);
                    if (LoggedUser.roles == Roles.Admin)
                    {
                        menu = new AdminManager(LoggedUser);
                    }
                }
                else
                {
                    Console.WriteLine("Login failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
