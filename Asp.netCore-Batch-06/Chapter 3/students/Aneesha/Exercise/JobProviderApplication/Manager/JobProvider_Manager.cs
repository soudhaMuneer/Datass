using JobProviderApplication.Interface;
using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Manager
{
    public class JobProvider_Manager:IApplicationProvider,IInterviewProvider,IJobProvider
    {
        //Application Apply = new Application();
        //Interview Intvw = new Interview();
        //Job jb = new Job();

        //private const int Max_JA = 50;
        //private const int Max_JI = 15;
        //private const int Max_Jb = 20;

        Application[] Apply = new Application[50];
        Interview[] Intrw = new Interview[15];
        Job[] jb = new Job[20];
        public Models.Application[] Applies = new Models.Application[50];
        private int numApp = 0;
        private int numIntrw = 0;
        private int numJb = 0;
        int id = 0;


        ////////////////////Jobs////////////////////////////////
        public void PostJob()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You can add job here.....");

            jb[0].Id = id;
            id++;

            Console.Write("Enter Job Title : ");
            string Title = Console.ReadLine();
            Console.Write("Enter Description : ");
            string Description = Console.ReadLine();
            Console.Write("Enter Salary : ");
            string Salary = Console.ReadLine();
            Console.Write("Enter Location : ");
            string Location = Console.ReadLine();
            Console.Write("Enter Type : ");
            string Type = Console.ReadLine();
            Console.Write("Enter Company : ");
            string Company = Console.ReadLine();

            Job newJob = new Job(id, Title, Description, Salary, Location, Type, Company);

            jb[numJb] = newJob;
            numJb++;

            Console.WriteLine("*******************************************************************");
        }

        public void GetJob()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("List job");
            Console.WriteLine("Job : ");

            for (int i = 0; i < numJb; i++)
            {
                Console.WriteLine($"id : {jb[i].Id}");
                Console.WriteLine($"Comapny : {jb[i].Title}");
                Console.WriteLine($"Post : {jb[i].Description}");
                Console.WriteLine($"Date : {jb[i].Salary}");
                Console.WriteLine($"Location : {jb[i].Location}");
                Console.WriteLine($"Time : {jb[i].Type}");
                Console.WriteLine($"Time : {jb[i].Company}");

            }
            Console.WriteLine("*******************************************************************");
        }
        ////////////////////Jobs//////////////////////////

        //////////////Job Application////////////////////
        public void AddApplication()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("You Can Apply Here");
            if (numApp < 50)
            {
                Apply[numApp] = new Application();
                Apply[numApp].Id = id;
                id++;
                numApp++;
                Console.WriteLine("Applyed successfulling");
            }
            else
            {
                Console.WriteLine("Application closed");
            }

            Apply[0].Id = id;
            id++;

            Console.Write("Enter your Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter your Location : ");
            string location = Console.ReadLine();
            Console.Write("Enter your Qualification : ");
            string qualification = Console.ReadLine();
            Console.Write("Enter you experiance : ");
            string experiance = Console.ReadLine();

            Applies[numApp]= new Models.Application(id, name, location, qualification,experiance);
            numApp = numApp++;
            Console.WriteLine("*******************************************************************");
            return;

        }

        public void GetApplication()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Your Application:");
            for (int i = 0; i< numApp; i++)
            {
                Console.WriteLine($"id : {Applies[i].Id}");
                Console.WriteLine($"Name : {Applies[i].Name}");
                Console.WriteLine($"Location : {Applies[i].Location}");
                Console.WriteLine($"Qualification : {Applies[i].Qualification}");
                Console.WriteLine($"Experiance : {Applies[i].Experiance}");
            }
            Console.WriteLine("*******************************************************************");
        }

        /////////////job Application ///////////////////////////////
        
        ///////////interview/////////////////////////////
         public void ScheduleInterview()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Welcome The Interview section Add Interview.");
            Intrw[0].Id = id;
            id++;

            Console.Write("Enter Company : ");
            string Company = Console.ReadLine();
            Console.Write("Enter Post : ");
            string Post = Console.ReadLine();
            Console.Write("Enter Date : ");
            string Date = Console.ReadLine();
            Console.Write("Enter Location : ");
            string Location = Console.ReadLine();
            Console.Write("Enter Time : ");
            string Time = Console.ReadLine();

            Interview newIntrw = new Interview(id, Company, Post,Date, Location,Time );

            Intrw[numIntrw] = newIntrw;
            numIntrw++;

            Console.WriteLine("Interview scheduled successfully");

            Console.WriteLine("*******************************************************************");
        }

        public void GetInterview()
        {
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Scheculed Interview");
            Console.WriteLine("Interviews : ");

            for (int i = 0; i<numIntrw; i++)
            {
                Console.WriteLine($"id : {Intrw[i].Id}");
                Console.WriteLine($"Comapny : {Intrw[i].Company}");
                Console.WriteLine($"Post : {Intrw[i].Post}");
                Console.WriteLine($"Date : {Intrw[i].Date}");
                Console.WriteLine($"Location : {Intrw[i].Location}");
                Console.WriteLine($"Time : {Intrw[i].Time}");
            }
            Console.WriteLine("*******************************************************************");
        }

        ///////////////interview/////////////////////////////

        
    }
}

 