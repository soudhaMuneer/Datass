using Admin_Portal.Enums;
using Admin_Portal.Interface;
using Admin_Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Repository
{
    public class JobRepository:IJobRepository
    {

        public static List<Job> jobs = new List<Job>()
       {
           new Job(){Id=1,Title=".NET Developer",Company="Aitrich Technologies",ExperienceLevel=ExperienceLevel.MidLevel,SalaryRange="$4000-5000",Location="Thrissur"},
           new Job(){Id=2,Title="Python Developer",Company="Infopark",ExperienceLevel=ExperienceLevel.Fresher,SalaryRange="$400-1000",Location="Kochi"},
            new Job(){Id=3,Title="Java Developer",Company="Dell",ExperienceLevel=ExperienceLevel.Senior,SalaryRange="$4000-12000",Location="Kochi"}
       };
        //public bool Newjob(Job job)
        //{
            
        //}
        public List<Job> Getjob()
        {
           return jobs;
        }
    }
}
