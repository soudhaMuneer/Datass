// See https://aka.ms/new-console-template for more information

using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace exercise
{
    class Program
    {
        struct Registration
        {
            public string? name;
            public string? email;
            public string? website;
            public int? phone;
            public string? location;
            public int? password;
        }
        static Registration[] register = new Registration[5];
        static int count = 0;
        struct Schedule
        {
            public string? title;
            public DateTime date;
            public string? time;
            public string? Location;
        }
        static Schedule[] Interviews = new Schedule[5];
        static Registration ? logedin;
        static void Main()
        {



            string ?choice;
            do
            {

                Console.WriteLine("------------------------------------Welcome to the Job seeker portal!------------------------------------\n");
                Console.WriteLine("---------------------------------------Welcome to the Job  portal!---------------------------------------\n");
                Console.WriteLine(" 1.Register Company \n 2.Login to Company \n ");
                Console.WriteLine("Select an option");
                int? inp = Convert.ToInt32(Console.ReadLine());
                switch (inp)
                {
                    case 1:

                        Register();
                        break;
                    case 2:
                        Login();
                        break;
                }
                Console.WriteLine("Do you want to continue (Y/N)\n");
                choice = Console.ReadLine();
            } while (choice == "y" || choice=="Y");

        }
        static bool log = true;
        static void Register()
        {
            Registration Registerdata = new Registration();
            Console.WriteLine("Please Enter Full Name");
            Registerdata.name = Console.ReadLine();
            Console.WriteLine("Please Enter Email");
            Registerdata.email = Console.ReadLine();
            Console.WriteLine("Please Enter Website");
            Registerdata.website = Console.ReadLine();
            Console.WriteLine("Please Enter Phone Number");
            Registerdata.phone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Location");
            Registerdata.location = Console.ReadLine();
            Console.WriteLine("Please Create Password");
            Registerdata.password = Convert.ToInt32(Console.ReadLine());

            if (Registerdata.name == "" && Registerdata.email == "" && Registerdata.website == "" && Registerdata.phone == 0 && Registerdata.location == "" && Registerdata.password == 123)
            {
                Console.WriteLine("Enter valid inputs");
            }
            else
            {
                Console.WriteLine("Registered Successfuly");
                    
            }

            register[count] = Registerdata;
            count++;
        }
        static void Login()
        {
            
            foreach (Registration reg in register)
            {


                Console.WriteLine("Please Enter Company Email");
                string? email = Console.ReadLine();

                Console.WriteLine("Please Enter Valid Password");
                int password = Convert.ToInt32(Console.ReadLine());
                if (email == reg.email && password == reg.password)
                {
                    Console.WriteLine("Login Successful\n");
                    Home();

                }
                else
                {
                    Console.WriteLine("Login Failed");
                    

                }
                logedin = reg;
            }



        }

        static void Home()
        {
            Console.WriteLine("Welcome To Aitrich\n");
            Console.WriteLine("1.Schedule Interview\n2.Scheduled Interview List\n3.Logout");
            int inp = Convert.ToInt32(Console.ReadLine());
            string? choice;

            switch (inp)
            {
                case 1:
                    Schedule shedule = new Schedule();


                    Console.WriteLine("How many no of interviews are sheduling\n");
                    int counts = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < counts; i++)
                    {

                        Console.WriteLine("----------------------------------------------------------Interviw shedule{0}--------------------------------------------------------------------------------------------", i + 1);
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        Console.Write("Enter the Name of job post {0}: ", i + 1);
                        shedule.title = Console.ReadLine();
                        Console.WriteLine("Enter the Date for Interview(dd-mm-yyyy)");
                        shedule.date = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter the Time of a Interview(h-m)");
                        shedule.time = Console.ReadLine();
                        Console.Write("Location of sheduled InterView {0}: ", i + 1);
                        shedule.Location = Console.ReadLine();
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        Interviews[count] = shedule;
                        count++;
                    }
                    break;

                case 2:


                    Console.WriteLine("----------------------------------------------------------Sheduled interview Details are are:---------------------------------------------------------------------------");
                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                    for (int i = 0; i < Interviews.Length; i++)
                    {
                        if (Interviews[i].title != null)
                        {
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                            Console.WriteLine("Name: {0}", Interviews[i].title);
                            Console.WriteLine("Date: {0}", Interviews[i].date.Date.ToString("MM/dd/yyyy"));
                            Console.WriteLine("Time :{0}", Interviews[i].time);
                            Console.WriteLine("Location: {0}", Interviews[i].Location);
                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                        }
                    }

                    break;
                case 3:
                    logout();
                    break;
            }
            Console.WriteLine("Do you want to Logout (Y/N)\n");
            choice = Console.ReadLine();
        }
            
        static void logout()
        {
            logedin= null;
            
        }

        }
    }


