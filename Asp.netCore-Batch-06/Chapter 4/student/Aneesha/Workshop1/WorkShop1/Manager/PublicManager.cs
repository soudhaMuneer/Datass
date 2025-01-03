using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WorkShop1.Exceptions;
using WorkShop1.Interface;
using WorkShop1.Models;
using WorkShop1.Repository;

namespace WorkShop1.Manager
{
    public class PublicManager:IMenu
    {
       UserRepository userRepository = new UserRepository();
        public User LoggedUser = new User();
        bool isLogged = false;
        IMenu menu;

        public void DisplayMenu()
        {
            showUserMenu();
        }
        private void showUserMenu() 
        {
            bool exitPrograme = false;  

            while(!exitPrograme)
            {
                Console.WriteLine("Choose an option: ");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Exit");

                string option1 = Console.ReadLine();
                switch(option1) 
                {
                    case "1":
                        LoginAdmin();
                        if(isLogged)
                            menu.DisplayMenu();
                        break;
                    case "2":
                        exitPrograme = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option ");
                        break;
                }
            }
        }
        void LoginAdmin()
        {
            try
            {
                
                string email = GetEmail();

                Console.WriteLine("enter passsword : ");
                string password = Console.ReadLine();

                LoggedUser = userRepository.login(email, password);
                if(LoggedUser != null)
                {
                    Console.WriteLine("Login successful");
                    isLogged = true;
                    Console.WriteLine("Welcome " + LoggedUser.FirstName);
                    if(LoggedUser.Role == Enums.Roles.Admin)
                    {
                        menu = new AdminManager(LoggedUser);
                    }
                }
                else
                {
                    Console.WriteLine("Login failed");
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
                Console.WriteLine("please enter your email address :");
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("Email was not in correct format: " + email);
                return email;
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again....");
                return GetEmail();
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message + "\n");
                return GetEmail();
            }
        }

        public long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your phone number:");
                long Phone = long.Parse(Console.ReadLine());
                return Phone;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhoneNumber();
            }
        }
    }
}
