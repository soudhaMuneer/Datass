﻿
using workshop3.Manager;

namespace JobSeeker // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jobseeker obj = new Jobseeker();
            Jobmanager Jobj = new Jobmanager();
            Console.WriteLine("Welcome to the job Seeker Part!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. List Job");

                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        obj.Register();
                        break;
                    case "2":
                        Jobj.ListJobs();
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}