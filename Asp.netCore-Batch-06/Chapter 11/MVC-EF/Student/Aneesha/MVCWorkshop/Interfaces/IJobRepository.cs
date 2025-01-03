using MVCWorkshop.Models;

namespace MVCWorkshop.Interfaces
{
    public interface IJobRepository
    {
        Job GetJobById(Guid selectedJobId);
        bool Create(Job job);
        List<Job> GetAllJobs();
        List<Job> GetJobs();
    }
}
