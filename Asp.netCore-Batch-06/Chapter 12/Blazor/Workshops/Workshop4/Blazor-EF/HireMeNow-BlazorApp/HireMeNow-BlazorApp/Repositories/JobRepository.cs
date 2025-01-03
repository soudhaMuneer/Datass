using HireMeNow_BlazorApp.Exceptions;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using Mvc_HireMeNow.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace HireMeNow_BlazorApp.Repositories
{
    public class JobRepository : IJobRepository
    {
		HireMeNowDbContext _context;
        public JobRepository(HireMeNowDbContext context)
        {
			 _context =context;
        }

		public void DeleteById(Guid id)
		{
			Job djob = _context.Jobs.Where(e => e.Id == id).FirstOrDefault();
			if (djob != null)
			{
				_context.Jobs.Remove(djob);
				_context.SaveChanges();
			}
			else
			{
                throw new NotFoundException();
            }

		}

		public List<Job> getByTitle(string title)
		{
			throw new NotImplementedException();
		}

		public Job GetJobById(Guid selectedJobId)
		{
			return _context.Jobs.Where(e=>e.Id==selectedJobId).FirstOrDefault();
		}

		public List<Job> GetJobs()
        {
            return _context.Jobs.ToList() ;
        }

        public List<Job> GetJobsByCompany(Guid cmpId)
        {
            return _context.Jobs.Where(j => j.CompanyId==cmpId).ToList();

        }

        public List<Job> GetJobsByIds(List<Guid> appliedJobsIds)
		{
			List<Job> Appliedjobs = new List<Job>();
			appliedJobsIds.ForEach(e=> Appliedjobs.Add(GetJobById(e)));
			return Appliedjobs;


		}

		

		public Job PostJob(Job job)
        {
			_context.Jobs.Add(job);
			_context.SaveChanges();
			return job;
        }

		public Job Update(Job job)
		{
			throw new NotImplementedException();
		}
	}
}
