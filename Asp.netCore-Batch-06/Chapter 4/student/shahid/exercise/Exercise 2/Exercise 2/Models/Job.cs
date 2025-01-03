using Exercise_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2.Models
{
    public class Job
    {
        //private string description;
        //private string type;
        //private string salary;

        public Job(int id,string title,Experiencelevel experience, string company, string location, string salary , string type)
        {
            Id = id;
            Title = title;
            //this.description = description;
            Location = location;
            JobType = type;
            SalaryRange = salary;
            Company = company;
            ExperienceLevel = experience;
        }
        public Job( string title, Experiencelevel experience, string company, string location, string salary, string type)
        {
            
            Title = title;
            //this.description = description;
            Location = location;
            JobType = type;
            SalaryRange = salary;
            Company = company;
            ExperienceLevel = experience;
        }
        public Job(string title, string company, string location, string salary, string type)
        {

            Title = title;
            //this.description = description;
            Location = location;
            JobType = type;
            SalaryRange = salary;
            Company = company;
            ExperienceLevel = Experiencelevel.Fresher;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public Experiencelevel ExperienceLevel { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType { get; set; }
    }
}
