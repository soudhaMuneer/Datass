using ConsoleApp4.Enums;
using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Lists
    {
        public void Print(List<User> Admin)
        {
            Console.WriteLine("---------------Registration----------------");
            if (Admin != null)
                foreach (User item in Admin)
                {
                    Console.WriteLine("Id : " + item.Id);
                    Console.WriteLine("First Name : " + item.FirstName);
                    Console.WriteLine("Last Name : " + item.LastName);
                    Console.WriteLine("Email : " + item.Email);
                    Console.WriteLine("Password : " + item.Password);
                    Console.WriteLine("Phone : " + item.Phone);
                    Console.WriteLine("Role : " + Roles.Admin);
                }
        }
        public void Print(List<Job> jobs)
        {
            Console.WriteLine("-------------Jobs------------");
            if(jobs != null) 
                foreach (Job job in jobs)
                {
                    Console.WriteLine("Id : " + job.Id);
                    Console.WriteLine("Title : " + job.Title);
                    Console.WriteLine("Description : " + job.Description);
                    Console.WriteLine("Location : " + job.Location);
                    Console.WriteLine("Salary : " + job.Salary);
                    Console.WriteLine("Type : " + job.Type);
                    Console.WriteLine("Company : " + job.Company);
                }
        }

    }

}

