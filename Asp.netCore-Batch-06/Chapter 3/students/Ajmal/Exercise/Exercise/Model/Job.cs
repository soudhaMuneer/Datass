using Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevels ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set;}

        public Job(int id, string title, string company, string location, string salary, string jbtype)
        {
            this.Id = id;
            this.Title = title;
            
            this.Company = company;
            this.Location = location;
            this.SalaryRange = salary;
            this.JobType = jbtype;

        }
        public Job() { }

    }
}
