using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Manager
{
    internal class JobManager:IJob
    {
        private Job[] job = new Job[10];
        private int count = 0;
        public void Addjob()
        {
            Console.WriteLine("Enter Job Title");
            string? title = Console.ReadLine();
            Console.WriteLine("Enter Job Discription");
            string? disc = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Job Location");
            string? location = Console.ReadLine();
            Console.WriteLine();
            Job newjob = new Job( title, disc, salary, location);
            job[count] = newjob;
            count++;
        }
        public void ListJob()
        {
            for (int i = 0; i < count; i++) {
                Console.WriteLine("************************************************************************************");

                Console.WriteLine("Job Title :- " + job[i].JobTitle);
                Console.WriteLine();
                Console.WriteLine("Job Description :- " + job[i].JobDescription);
                Console.WriteLine();

                Console.WriteLine("Job Salary :- " + job[i].Salary);
                Console.WriteLine();

                Console.WriteLine("Job Location :- " + job[i].Location);
                Console.WriteLine();


                Console.WriteLine("************************************************************************************");


            }
        }
    } }
