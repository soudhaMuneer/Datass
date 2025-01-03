﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Models
{
     public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Salary { get; set; }
        public string Location { get; set; }
        public string Type { get; set; }
        public string Company { get; set; }
        public Job(int Id,string Title,string Description,string Salary,string Location,string Type,string Company)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.Salary = Salary;
            this.Location = Location;
            this.Type = Type;
            this.Company = Company;
        }
        public Job()
        {

        }
    }
}
