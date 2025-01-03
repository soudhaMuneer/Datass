using Exercise.Enums;
using Exercise.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Model
{
    public class JobSeeker
    {

       public static Job[] Appliedjob=new Job[10];
        public static Job[] Savedjob=new Job[10];
        int count = 0;
        public int id {  get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email {  get; set; }
        public string? Phone { get; set; }
        public string? Location { get; set; }
        public string? AboutMe {  get; set; }
        public string? Qualification {  get; set; }
        public ExperienceLevels ExperienceLevel {  get; set; }
        public string? password {  get; set; }

        public JobSeeker(string FirstName,string ln,string mail,string phone,string location,string aboutme,string Qualification, string pass) 
        {
            this.FirstName = FirstName;
            this.LastName = ln;
            this.Email = mail;
            this.Phone = phone;
            this.Location = location;
            this.AboutMe = aboutme;
            this.Qualification=Qualification;
           
            this.password = pass;
        }
        

  
        public void addAppliedJob(Job apply)
        {
            if (count < 10)
            {
                Appliedjob[count] = apply;
                Console.WriteLine("Job Applied successfully...");
                count++;
                
            }
            else
            {
                Console.WriteLine("No Jobs Applied");
            }


        }
        public Job[] getappliedJobs()
        {
            for (int i = 0; i < Appliedjob.Length; i++)
            {
                if (Appliedjob[i] == null)
                {
                    break;
                }
                else
                {

                    Console.WriteLine("----------------------------------------------------------------Job {0}----------------------------------------------------------------", i + 1);
                    Console.WriteLine("Job Title:- {0,-10} Job Company:- {0,-20}\nCompany Location:- {0,-10} Job Type:- {0,-20}\n Experience Level:- {0,-10} Salary:- {0,-20}", Appliedjob[i].Title, Appliedjob[i].Company, Appliedjob[i].Location, Appliedjob[i].JobType, Appliedjob[i].SalaryRange);
                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------");

                }

            }
            return Appliedjob;
            
        }
        public void addsavedJob(Job save)
        {
            if (count < 10)
            {
                Savedjob[count] = save;
                Console.WriteLine("Job Saved successfully...");
                count++;
            }
            else
            {
                Console.WriteLine("No Jobs Saved");
            }
        }
        public Job[] GetsavedJobs() {
            int j = 0;
            foreach (Job i in Savedjob)
            {

                 Console.WriteLine("----------------------------------------------------------------Job {0}----------------------------------------------------------------", j + 1);
                    Console.WriteLine("Job Title:- {0,-10} Job Company:- {0,-20}\nCompany Location:- {0,-10} Job Type:- {0,-20}\n Experience Level:- {0,-10} Salary:- {0,-20}" , i.Title,i.Company,i.Location,i.JobType,i.SalaryRange);
                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");

                break;
            }
            return Savedjob;

        }
        public JobSeeker()
        {
                
        }

    }
}
