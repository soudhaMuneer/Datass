using RazorWorkshop4.Models;

namespace RazorWorkshop4.Interfaces
{
    public interface IJobProvider
    {
        bool PostJob(Job job);
        List<Job> GetJobs();

    }
}
