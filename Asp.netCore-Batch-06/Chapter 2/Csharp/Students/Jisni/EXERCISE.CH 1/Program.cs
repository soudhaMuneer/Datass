using System;
using System.Diagnostics;

namespace MyApp
{
    internal class Program
    {
        struct AcDetails
        {
            public string email;
            public string password;


        }

        static AcDetails[] Shedule = new AcDetails[1];
        static AcDetails loggedinUser;
        static int userCount = 0;
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the jobseeker Portal!");



            string ab;



            do
            {

                Console.WriteLine("welcome to the job Portal");
                Console.WriteLine("1 . Register");
                Console.WriteLine("2 . Login");

                Console.WriteLine("Select an Option");

                int Content = Convert.ToInt32(Console.ReadLine());


                switch (Content)
                {
                    case 1:
                        Register();
                        break;

                    case 2:
                        Login();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

                Console.WriteLine("Do you want to continue (Y/N)");
                ab = Console.ReadLine();
            }
            while (ab == "y" || ab == "Y");


        }
        static void Register()
        {
            AcDetails Details = new AcDetails();


            Console.WriteLine();
            Console.WriteLine("Enter Email:");
            Details.email = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            Details.password = Console.ReadLine();



            Shedule[userCount] = Details;
            userCount++;
        }

        static void Login()
        {

            Console.WriteLine();
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine();


            bool loginSuccessfull = false;

            foreach (AcDetails det in Shedule)
            {
                if (det.email == email && det.password == password)
                {
                    loginSuccessfull = true;
                    loggedinUser = det;

                    Console.WriteLine("Login Successfull");
                    Console.WriteLine();
                    Console.WriteLine("Here are your details:");

                    Console.WriteLine("Email:{0}", loggedinUser.email);
                    Console.WriteLine("Password:{0}", loggedinUser.password);

                    Console.WriteLine();

                    string cd;

                    do
                    {
                        Console.WriteLine("----WELCOME   {0} !", Shedule[0].email, "\n");

                        Console.WriteLine("1 . List All Jobs");
                        Console.WriteLine("2 . My Profile");
                        Console.WriteLine("3 . Logout");

                        Console.WriteLine("please Select Option");

                        int welcome = Convert.ToInt32(Console.ReadLine());

                        switch (welcome)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Jobs Available : ");
                                    Console.WriteLine(" {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} | {5,-20} ", "Id", "Title", "Experience", "Company", "Location", "Salary");
                                    Console.WriteLine(" {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} | {5,-20} ", "1", "Software Engineer", "3+ years", "Acme Inc.", "New York ,NY ", "$100,000 - $150,000");
                                    Console.WriteLine(" {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} | {5,-20} ", "1", "Product Manager", "4+ years", "Globex Corp", "San Francisco, CA ", "$100,000 - $150,000");
                                    Console.WriteLine(" {0,-20} | {1,-20} | {2,-20} | {3,-20} | {4,-20} | {5,-20} ", "1", "Marketing Specialist", "3+ years", "Acme Inc.", "New York ,NY ", "$100,000 - $150,000");



                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("*MY PROFILE*");
                                    Console.WriteLine("----WELCOME   {0} !", Shedule[0].email, "\n");
                                    Console.WriteLine("email :{0} ", Shedule[0].email, "\n");
                                    Console.WriteLine("password :{0} ", Shedule[0].password, "\n");


                                    break;

                                }


                            case 3:
                                {

                                    break;

                                }


                        }

                        Console.WriteLine("Go Back (Y/N)\n");
                        cd = Console.ReadLine();

                    } while (cd == "y" || cd == "Y");














                }

            }

        }

        static void Logout()
        {

        }


    }
}














