﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Models;

namespace WorkShop1
{
    public class Lists
    {
        public void Print(List<User> Admins)
        {
            Console.WriteLine("Registrations : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} ", "Id", "FirstName", "LastName", "Phone", "Email");
            if (Admins != null)
                foreach (User Item in Admins)
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} ", Item.Id, Item.FirstName, Item.LastName, Item.Phone, Item.Email);
                }
            Console.WriteLine("\n");
        }

        public void Print(List<Jobs> jobs)
        {
            Console.WriteLine("Jobs : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", "JobId", "Title", "Description", "Company", "Location", "SalaryRange", "JobType");
            if(jobs != null)
                foreach (Jobs job in jobs)
                {
                    Console.WriteLine("**************************************************");
                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", job.Id, job.Title, job.Description, job.Company, job.Location, job.Salary, job.Type);
                }
            Console.WriteLine("\n");
        }
    }
}