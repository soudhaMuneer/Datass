using Admin_Portal.Exceptions;
using Admin_Portal.Interface;
using Admin_Portal.Model;
using Admin_Portal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Admin_Portal.Services
{
    public class Jobportal : IMenu
    {
        public static User user=new User();
        public static User log=new User();
        public static UserRepository userRepository = new UserRepository();
        public static Jobseeker jobseeker = new Jobseeker();
        public static Admin admin = new Admin();
        public void Menu()
        {
            ShowDisplayMenu();
        }

        public void ShowDisplayMenu()
        {
            Console.WriteLine("Welcome To Job Portal System");
            Console.WriteLine();
            Console.WriteLine("1.Register\n2.Login\n3.Exit");
            Console.WriteLine();
            Console.WriteLine("Choose Any Options");
            string choose=Console.ReadLine();
            switch(choose)
            {
                case "1":
                    Console.Write("Enter Your Name : ");
                    user.Name = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Enter Your Last Name : ");
                    user.Lname = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Enter Your Email : ");
                    user.Email = GetEmail();
                    Console.WriteLine();
                    Console.Write("Create Your Password : ");
                    user.Password = GetPassword();
                    Console.WriteLine();
                    userRepository.Newuser(user);
                    ShowDisplayMenu();
                    break;
                case "2":
                    Login();
                    break;
                case "3":
                    return;
                    break;

            }
        }
        public void Login()
        {
            Console.Write("Enter Your Email : ");
            string Email = GetEmail();
            Console.WriteLine();
            Console.Write("Create Your Password : ");
            string Password = GetPassword();
            log=userRepository.login(Email, Password);
            if (Email=="admin@gmail.com" && Password == "Admin@123")
            {
                Console.WriteLine("Login Successfuly !!!");
                Console.WriteLine("Welcome Admin");
                Console.WriteLine();
                admin.Menu();
            }
            if (log != null)
            {
                Console.WriteLine("Login Successfuly !!!");
                Console.WriteLine("Welcome {0} To Job-Portal", log.Name);
                Console.WriteLine();
                Jobseeker login = new Jobseeker(log);
            }
        }
        private string GetEmail()
        {
            try
            {
               
                string email = Console.ReadLine();
                Regex regex = new Regex("^\\S+@\\S+\\.\\S+$");

                if (!regex.IsMatch(email))
                    throw new InvalidFormatException("Email was not in correct format :" + email);
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
        private string GetPassword()
        {
            try
            {

                string password = Console.ReadLine();
                Regex regex = new Regex("123");

                if (!regex.IsMatch(password))
                    throw new InvalidFormatException("Password was not in correct format :" + password);
                return password;
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again...");
                return GetPassword();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                return GetPassword();
            }
        }


    }
}
