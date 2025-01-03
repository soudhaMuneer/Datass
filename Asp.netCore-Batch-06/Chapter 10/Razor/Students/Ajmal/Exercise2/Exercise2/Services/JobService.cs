using Exercise2.Interface;
using Exercise2.Models;
using Exercise2.Repositories;

namespace Exercise2.Services
{
    public class JobService:IJob
    {
       
        
        private readonly IJobRepository jobRepository;
      
        public JobService( IJobRepository _jobRepository)
        {
          
           
            jobRepository = _jobRepository;
            
        }

        public List<Job> ListJob()
        {
            return jobRepository.ListJob();
        }

       
    }
}
