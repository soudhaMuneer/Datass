using Admin_Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal
{
    public class Lists
    {
        public void Print(List<Job> jobs)
        {
            Console.WriteLine("Jobs available: \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20}    ", "JobId", "Title", "ExperienceLevel", "Company", "Location", "SalaryRange");

            foreach (Job job in jobs)
            {
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20}    ", job.Id, job.Title, job.ExperienceLevel, job.Company, job.Location, job.SalaryRange);
            }
        }
        public void Print(List<User> users)
        {
            
            Console.WriteLine("{0,-10} | {1,-30} | {2,-30} | {3,-30}", "UserId", "Name", "Last Name", "Email");
            
                foreach (User user in users)
                {
                    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("{0,-10} | {1,-30} | {2,-30} | {3,-30}", user.Id, user.Name, user.Lname, user.Email);
                }
           
        }
    }
}
