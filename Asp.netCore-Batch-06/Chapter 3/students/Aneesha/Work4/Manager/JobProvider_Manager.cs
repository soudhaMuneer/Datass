using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Work4.Interface;
using Work4.Model;

namespace Work4.Manager
{
    public class JobProvider_Manager : JobRepo, UserRepo
    {
        JobProvider.Model.JobProvider proId = new JobProvider.Model.JobProvider();
        Job job = new Job();
        private const int Max_JPro = 10;
        public const int Max_Job = 100; 
        public Model.JobProvider[] Provider = new Model.JobProvider[Max_JPro];
        
        private int numPro = 0;

        private Job[] jobs = new Job[Max_Job];
        private int numJob = 0;
        int id = 0;

        public void Register()
        {
            if (numPro == Max_JPro)
            {
                Console.WriteLine("Maximum number of Providers reached.please try again later..");
                return;
            }
            proId.Id = id;
            id++;

            Console.WriteLine("Enter firstname :");
            string? firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname :");
            string? lastname = Console.ReadLine();

            Console.WriteLine("Enter a email :");
            string? email = Console.ReadLine();

            Console.WriteLine("Enter designation :");
            string? designation = Console.ReadLine();

            Console.WriteLine("Enter a password : ");
            string? password = Console.ReadLine();

            for (int i = 0; i < numPro; i++)
            {
                if (Provider[i].Email == email)
                {
                    Console.WriteLine("Username already taken.Please choose another username.");
                    return;
                }
            }
            Provider[numPro] = new Model.JobProvider(id, firstname, lastname, email, designation, password);
            numPro = numPro++;

            Console.WriteLine("Registration successful.Please log in to continue.");

        }


        public void Login()
        {
            Console.WriteLine("Enter Email :");
            string? email = Console.ReadLine();

            Console.WriteLine("Enter password :");
            string? password = Console.ReadLine();

            //Console.WriteLine(numPro);

            for (int i = 0; i < Provider.Length; i++)
            {
                if (Provider[i].Email == email && Provider[i].Password == password)
                {
                    string input = "0";
                    while (input != "3")
                    {
                        Console.WriteLine("Login successful");
                        Console.WriteLine("1. Add Job");
                        Console.WriteLine("2.List Job");
                        Console.WriteLine("3. back to main");
                        input = Console.ReadLine();

                        if (input == "1")
                        {
                            AddJob();
                        }
                        else if (input == "2")
                        {
                            ListJob();
                        }
                        else if (input == "3")
                        {
                            Console.WriteLine("Back to menu");
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }

                    }
                    return;

                }
            }
            Console.WriteLine("Invalid username or password");
        }

        public void AddJob()
        {

            int Max_job = 0;
            if (numJob == Max_job)
            {
                Console.WriteLine("Maximum number of jobs reached please try again later");
                return;
            }
            job.Id = id;
            id++;
            Console.WriteLine("Enter job title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter job description");
            string description = Console.ReadLine();

            Console.WriteLine("Enter job salary");
            string salary = Console.ReadLine();

            Console.WriteLine("Enter location");
            string location = Console.ReadLine();

            Job newJob = new Job(id, title, description, salary, location);
            jobs[numJob] = newJob;
            numJob++;

            Console.WriteLine("Job added successfully . ");

        }

        public void ListJob()
        {
            Console.WriteLine("Jobs : ");
            for(int i =0; i< numJob; i++) 
            {
                Console.WriteLine($"id: {jobs[i].Id}");
                Console.WriteLine($"Title: {jobs[i].Title}");
                Console.WriteLine($"Description: {jobs[i].Description}");
                Console.WriteLine($"Salary: {jobs[i].Salary}");
                Console.WriteLine($"Location: {jobs[i].Location}");
            }
        }
    }
}
