
using CompanyMember.Model;
using CompanyMember.Repository;
using CompanyMemberRegistration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyMember
{
    public class Lists
    {
        ApplicationRepository applicationrepository = new ApplicationRepository();
       public Application applications = new Application();
        public void Print(List<Company> companies)
        {
            Console.WriteLine("Companies : \n");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20} |  {7,-20} |  {8,-20}  ", "Name", "Email", "website", "phone", "about", "vision", "mission", "location", "address");
            
            if (companies != null)
                foreach (Company company in companies)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------");

                    Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20} |  {7,-20} |   {8,-20} |  ", company.Name,company.Email,company.Website,company.Phone,company.About,company.Vision,company.Mission,company.Location,company.Address);
                }

            Console.WriteLine("\n");

        }
       
        public void Print(List<Job> jobs)
		{
			Console.WriteLine("Jobs available: \n");
			Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", "JobId", "Title", "ExperienceLevel", "Company", "Location", "SalaryRange", "JobType");
			
			foreach (Job job in jobs)
			{
				Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");

				Console.WriteLine("{0,-10} | {1,-20} | {2,-20} | {3,-20} | {4,-20} |  {5,-20} |  {6,-20}   ", job.Id, job.Title, job.ExperienceLevel, job.Company, job.Location, job.SalaryRange, job.JobType);
			}

            
            Console.WriteLine("Apply job with ID : ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (jobs.Find(s => s.Id == num) != null)
            {
                
                foreach (Job job in jobs)
                {
                    applications.Jobtitle = job.Title;
                    Console.WriteLine("Enter your name :");
                    applications.Name = Console.ReadLine();
                    Console.WriteLine("Enter your Qualification :");
                    applications.Qualification = Console.ReadLine();
                    Console.WriteLine("Enter your Experience :");
                    applications.Experience = Console.ReadLine();
                    Console.WriteLine("Enter your Location :");
                    applications.Location = Console.ReadLine();
                    bool output = applicationrepository.Applyjob(applications);
                    if (output == true)
                    {
                        Console.WriteLine("Successfuly Applied for : {0}", job.Title);
                    }
                }



            }

            Console.WriteLine("\n");
		}

        public void Print(List <Application> applied)
        {
            
                foreach (Application applicant in applied )
                {
                    Console.WriteLine("---------------------------------------------------------Job Applied for : {0}---------------------------------------------------------", applicant.Jobtitle);
                    Console.WriteLine("{0,-10} | {1,-30} | {2,-30} | {3,-30} | {4,-30}", "JobId", "Name", "Qualification", "Experience", "Location");
                    Console.WriteLine("{0,-10} | {1,-30} | {2,-30} | {3,-30} | {4,-30}", applicant.Id, applicant.Name, applicant.Qualification, applicant.Experience, applicant.Location);
                }
            
        }

        }
}

