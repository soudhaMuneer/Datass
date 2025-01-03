using MVCWorkshop.Models;

namespace MVCWorkshop.Interfaces
{
    public interface IJobService
    {
        Job getJobById(Guid selectedJobId);
         List<Job> GetJobs();
    }
}
