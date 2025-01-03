using MVCWorkshop.Interfaces;
using MVCWorkshop.Models;
using System.Data.Entity;

namespace MVCWorkshop.Repository
{
    public class JobRepo : IJobRepository
    {
        JobPortalDbContext _context = new JobPortalDbContext();
        public JobRepo(JobPortalDbContext context)
        {
            _context = context;
        }
        public Job GetJobById(Guid selectedJobId)
        {
            Job job = _context.Jobs.Find(selectedJobId);
            return job;
        }
        public bool Create(Job job)
        {
            _context.Jobs.Add(job);
            _context.SaveChanges();
            return true;
        }
        public List<Job> GetAllJobs()
        {
            return _context.Jobs.Include(e=>e.Company).ToList();    
        }

        public List<Job> GetJobs()
        {
            return _context.Jobs.ToList();
        }
    }
}
