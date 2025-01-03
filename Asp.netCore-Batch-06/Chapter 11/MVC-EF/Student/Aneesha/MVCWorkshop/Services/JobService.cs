using MVCWorkshop.Interfaces;
using MVCWorkshop.Models;

namespace MVCWorkshop.Services
{
    public class JobService : IJobService
    {
        IJobRepository _JobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _JobRepository = jobRepository;
        }


        public Job getJobById(Guid selectedJobId)
        {
            return _JobRepository.GetJobById(selectedJobId);
        }

        public List<Job> GetJobs()
        {
            return _JobRepository.GetJobs();
        }
    }
}
