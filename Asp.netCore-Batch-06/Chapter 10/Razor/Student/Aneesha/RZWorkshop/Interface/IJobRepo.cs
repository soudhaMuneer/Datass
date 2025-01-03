using RZWorkshop.Models;

namespace RZWorkshop.Interface
{
    public interface IJobRepo
    {

        Jobss PostJob(Jobss jobss);
        Jobss Update(Jobss jobss);
        List<Jobss> GetJobs();

        Jobss GetJobById(Guid jobId);

        void DeleteJobById(Guid jobId);
       


    }
}
