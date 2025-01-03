using HireMeNow_BlazorApp.Exceptions;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace HireMeNow_BlazorApp.Repositories
{
    public class JobRepository : IJobRepository
    {
        private List<Job> jobs = new List<Job> { new Job("Dotnet Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),"Aitrich",new Guid("62ec44fb-9f30-4f45-8e3d-f3751998af89")),
		new Job("Java Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),"Aitrich"),
		new Job("Angular Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),"Aitrich"),
		new Job("Dotnet Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),"Aitrich"),
		new Job("Dotnet Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),"Aitrich")};
		
	

		public void DeleteById(Guid id)
		{
			Job item = jobs.FirstOrDefault(i => i.Id == id);
			if (item != null)
			{
				jobs.Remove(item);
			}
		}

		public List<Job> getByTitle(string title)
		{
			
			return jobs.Where(j => j.Title.ToLower().Contains( title.ToLower())).ToList();


		}

		public Job GetJobById(Guid selectedJobId)
		{
			return jobs.Where(e=>e.Id==selectedJobId).FirstOrDefault();
		}

		public List<Job> GetJobs()
        {
            return jobs;
        }

		public List<Job> GetJobsByIds(List<Guid> appliedJobsIds)
		{
			List<Job> Appliedjobs = new List<Job>();
			appliedJobsIds.ForEach(e=> Appliedjobs.Add(GetJobById(e)));
			return Appliedjobs;


		}

		

		public Job PostJob(Job job)
        {
            job.Id = Guid.NewGuid(); 
            jobs.Add(job);
			return job;
        }

		public Job Update(Job Updatedjob)
		{
			int indexToUpdate = jobs.FindIndex(item => item.Id == Updatedjob.Id);
			if (indexToUpdate != -1)
			{
				// Modify the properties of the item at the found index
				jobs[indexToUpdate].Title = Updatedjob.Title ?? jobs[indexToUpdate].Title;
				jobs[indexToUpdate].Description = Updatedjob.Description ?? jobs[indexToUpdate].Description;
				jobs[indexToUpdate].Location = Updatedjob.Location ?? jobs[indexToUpdate].Location;
				jobs[indexToUpdate].Salary= Updatedjob.Salary ?? jobs[indexToUpdate].Salary;
				jobs[indexToUpdate].TypeOfWork = Updatedjob.TypeOfWork ?? jobs[indexToUpdate].TypeOfWork;
				jobs[indexToUpdate].Experience = Updatedjob.Experience ?? jobs[indexToUpdate].Experience;
				jobs[indexToUpdate].CompanyName = Updatedjob.CompanyName ?? jobs[indexToUpdate].CompanyName;
				jobs[indexToUpdate].Type = Updatedjob.TypeOfWork ?? jobs[indexToUpdate].TypeOfWork;


			}
			else
			{
				throw new NotFoundException("Job Not Found");
			}
			return jobs[indexToUpdate];
		}
	}
}
