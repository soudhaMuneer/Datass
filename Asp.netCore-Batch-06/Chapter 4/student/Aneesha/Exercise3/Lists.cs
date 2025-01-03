using Exercise3.Interface;
using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise3
{
    public class Lists
    {
        public void Print(List<User> JobProvider)
        {
            Console.WriteLine("Job Provider's Registration : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", "Id", "Name", "CompanyName", "Email", "Password", "PhoneNumber");
            if (JobProvider != null)
                foreach (User item in JobProvider)
                {
                    Console.WriteLine("**********************************************************************************************************************");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", item.Id, item.Name, item.CompanyName, item.Email, item.Password, item.phoneNumber);
                }
            Console.WriteLine();
        }

        public  void Print(List<Jobs> jobs)
        {
            Console.WriteLine("List of Posted Jobs : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", "Id", "Title", "Description", "Location", "Type", "Salary","Company");
            if (jobs != null)
            {
                foreach (Jobs job in jobs)
                {
                    Console.WriteLine("************************************************************************************************************************************");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", job.Id, job.Title, job.Description, job.Location, job.Type, job.Salary, job.Company);
                }
            }
            Console.WriteLine();
        }

        public void Print(List<Model.Application> applications)
        {
            Console.WriteLine("List all Application : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", "Id", "FirstName", "LastName", "Email", "Phone", "Location", "About Me","Qualification","ExperianceLevel");
            if(applications != null)
                foreach(Model.Application application in applications)
                {
                    Console.WriteLine("************************************************************************************************************************************");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}",application.Id,application.FirstName,application.Email,application.Phone,application.Location,application.AboutMe,application.Qualification,application.ExperienceLevels );
                }
        }

        public void Print(List<Interview> interview)
        {
            Console.WriteLine("List all Application : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}", "Id", "company", "job", "date", "location", "time");
            if (interview != null)
                foreach(Interview interview1 in interview)
                {
                    Console.WriteLine("************************************************************************************************************************************");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20}",interview1.Company,interview1.Job,interview1.Date,interview1.Location,interview1.Time);
                }
        }
    }

    }

    
