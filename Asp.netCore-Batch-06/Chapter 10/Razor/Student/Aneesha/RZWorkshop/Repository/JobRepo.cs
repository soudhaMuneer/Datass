using Microsoft.EntityFrameworkCore;
using RZWorkshop.Interface;
using RZWorkshop.Models;

namespace RZWorkshop.Repository
{
    public class JobRepo :IJobRepo
    {
        RzworkshopContext context = new RzworkshopContext();
        private readonly List<Jobss> jobs;

        public Jobss PostJob(Jobss jobss)
        {
            context.Jobsses.Add(jobss);
            context.SaveChanges();  
            return jobss;
        }

        public Jobss Update(Jobss jobss)
        {
            int idForUpdate = jobs.FindIndex(e => e.Id == jobss.Id);
            if (idForUpdate > -1)
            {
                jobs[idForUpdate].Title = jobss.Title;
                jobs[idForUpdate].Description = jobss.Description;
                jobs[idForUpdate].Location = jobss.Location;
                jobs[idForUpdate].Experience = jobss.Experience;
                jobs[idForUpdate].TypeOfWorkPlace = jobss.TypeOfWorkPlace;
                jobs[idForUpdate].Salary = jobss.Salary;
                jobs[idForUpdate].Responsibilities = jobss.Responsibilities;
                jobs[idForUpdate].JobType = jobss.JobType;
                jobs[idForUpdate].VacanciesCount = jobss.VacanciesCount;
                jobs[idForUpdate].AppliedCount = jobss.AppliedCount;
                jobs[idForUpdate].Status= jobss.Status;
                jobs[idForUpdate].CreatedDate= jobss.CreatedDate;
                jobs[idForUpdate].CreatedBy= jobss.CreatedBy;
            }
            else
            {
                throw new Exception("Job not found");
            }
            return jobs[idForUpdate];
        }

        public List<Jobss> GetJobs()
        {
            return context.Jobsses.ToList();
        }

        public Jobss GetJobById(Guid jobId)
        {
            Jobss jobs = context.Jobsses.FirstOrDefault(e=>e.Id==jobId);
            return jobs;

        }

        public void DeleteJobById(Guid jobId)
        {
            var job = context.Jobsses.Find(jobId);
            if (job != null)
            {
                context.Jobsses.Remove(job);
                context.SaveChanges();
            }
        }

    }
    
}
