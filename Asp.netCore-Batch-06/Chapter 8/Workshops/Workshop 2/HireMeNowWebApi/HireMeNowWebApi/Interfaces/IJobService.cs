using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IJobService
    {
       
        public Job getJobById(Guid selectedJobId);
        List<Job> GetJobs();
    }
}
