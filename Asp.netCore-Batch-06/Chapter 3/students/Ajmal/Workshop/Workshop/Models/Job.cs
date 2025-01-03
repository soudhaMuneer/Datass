using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public int Salary { get; set; }
        public string Location { get; set; }

        public Job(string title, string description, int salary, string location)
        {

            this.JobTitle = title;
            this.JobDescription = description;
            this.Salary = salary;
            this.Location = location;
        }


    }
}
