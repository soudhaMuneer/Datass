using HireMeNow.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow.Models
{
    public class JobSeeker
    {
        int AppliedJobCount = 0;
        int SavedJobCount = 0;
        public static Job[] AppliedJob=new Job[10];
        public static Job[] SavedJob=new Job[10];
        public int Id {  get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public string Phone {  get; set; }
        public string Location {  get; set; }
        public string AboutMe {  get; set; }
        public string Qualification {  get; set; }
        public string Password {  get; set; }
        public ExperienceLevel Experience {  get; set; }

        public JobSeeker(string firstName, string lastName, string email, string phone, string location, string aboutMe, string qualification, string password, ExperienceLevel experience)
        {
            
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Location = location;
            AboutMe = aboutMe;
            Qualification = qualification;
            Password = password;
            Experience = experience;
        }

        public void addAppliedJob(Job job)
        {
            if(AppliedJobCount<10)
            {
                AppliedJob[AppliedJobCount]= job;
                Console.WriteLine("Job applied successfully!!!!");
                AppliedJobCount++;
            }
            else
            {
                Console.WriteLine("Job limit exceeded");
            }
        }
        public Job[] getAppliedJob()
        {
            for(int i = 0;i<AppliedJob.Length;i++)
            {
                if(AppliedJob[i] == null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("------Applied Jobs-------");
                    Console.WriteLine(AppliedJob[i].Title);
                    Console.WriteLine(AppliedJob[i].Company);
                    Console.WriteLine(AppliedJob[i].Location);
                    Console.WriteLine(AppliedJob[i].JobType);
                    Console.WriteLine(AppliedJob[i].SalaryRange);

                }
            }
            return AppliedJob;
        }
        public void addSavedJob(Job job)
        {
            if(SavedJobCount<10)
            {
                SavedJob[SavedJobCount]= job;
                Console.WriteLine("Job saved successfully!!!");
                SavedJobCount++;
            }
            else
            {
                Console.WriteLine("Save jobs limit exceeded");
            }
        }
        public Job[] getSavedJob()
        {
            foreach(Job job in SavedJob)
            {
                Console.WriteLine("--------Saved Jobs-----");
                Console.WriteLine(job.Title);
                Console.WriteLine(job.Company);
                Console.WriteLine(job.Location);
                Console.WriteLine(job.JobType);
                Console.WriteLine(job.SalaryRange);
                break;
            }
            return SavedJob;
        }
        public JobSeeker()
        {

        }
    }
}
