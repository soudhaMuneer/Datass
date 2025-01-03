using RZWorkshop.Interface;
using RZWorkshop.Models;

namespace RZWorkshop.Service
{
    public class JobService : IJobService
    {
        IJobRepo _jobrepo;
        public JobService() { }

        public JobService(IJobRepo jobrepo)
        {
            _jobrepo = jobrepo;
        }
        public Jobss PostJob(Jobss jobss)
        {
            return _jobrepo.PostJob(jobss);
        }
        public Jobss Update(Jobss jobss)
        {
            var updateJob = _jobrepo.Update(jobss);
            return updateJob;
        }
        public List<Jobss> GetJobs()
        {
            return _jobrepo.GetJobs();
        }
        public Jobss GetJobById(Guid jobId)
        {
            return _jobrepo.GetJobById(jobId);
        }
        public void DeleteJob(Guid jobId)
        {
            _jobrepo.DeleteJobById(jobId);
        }

        public void DeleteJobById(Guid jobId)
        {
            _jobrepo.DeleteJobById(jobId);
        }
    }

}