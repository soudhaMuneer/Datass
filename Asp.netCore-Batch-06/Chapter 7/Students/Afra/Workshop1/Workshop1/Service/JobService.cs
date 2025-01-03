using Workshop1.Repository;
using Workshop1.Model;
namespace Workshop1.Service
{
    public class JobService
    {
        JobRepository repository;
        public JobService(JobRepository jobrepository)
        {
            repository = jobrepository;
        }

        public void AddJoblist(Job job)
        {
            repository.AddJob(job);
        }

        public List<Job> GetJobList()
        {
            return repository.GetJobs();
        }

        public Job GetJobById(int id)
        {
            return repository.GetJobById(id);
        }

        public void DeleteJobList(Job job)
        {
            repository.DeleteJob(job);
        }
    }
}
