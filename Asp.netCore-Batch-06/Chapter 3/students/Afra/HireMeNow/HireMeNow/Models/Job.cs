using HireMeNow.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ExperienceLevel Experience {  get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string SalaryRange { get; set; }
        public string JobType {  get; set; }
       public Job(int id, string title, ExperienceLevel experience, string company, string location, string salaryRange, string jobType)
        {
            Id = id;
            Title = title;
            Experience = experience;
            Company = company;
            Location = location;
            SalaryRange = salaryRange;
            JobType = jobType;
        }
        public Job()
        { 
        }
    }
}
