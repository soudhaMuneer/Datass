using HireMeNowWebApi.Exceptions;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace HireMeNowWebApi.Repositories
{
    public class JobRepository : IJobRepository
    {
        private List<Job> jobs = new List<Job> { new Job("Dotnet Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid(),"Aitrich",new Guid("62ec44fb-9f30-4f45-8e3d-f3751998af89")),
		new Job("Java Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid(),"Aitrich"),
		new Job("Angular Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid(),"Aitrich"),
		new Job("Dotnet Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid(),"Aitrich"),
		new Job("Dotnet Developer","Senior dotnet developer .","kochi","Fulltime","100000-300000",new Guid(),"Aitrich")};
		private readonly List<Job> _jobs;
		

		

		public List<Job> getByTitle(string title)
		{
			//List<Job> job= (List<Job>)jobs.Where(e => e.Title == title);
			//return job;
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

		

		

		public Job PostJob(Job job)
        {
            job.Id = Guid.NewGuid(); 
            jobs.Add(job);
			return job;
        }

		
	}
}
