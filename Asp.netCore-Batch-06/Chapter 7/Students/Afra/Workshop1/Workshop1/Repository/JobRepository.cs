using Workshop1.Model;
namespace Workshop1.Repository
{
    public class JobRepository
    {
        List<Job> jobList=new List<Job>();
        public void AddJob(Job job)
        {
            job.Id = jobList.Count + 1;
            jobList.Add(job);
        }

        public Job GetJobById(int id) 
        {
            return jobList.FirstOrDefault(j=>j.Id==id);
        }

        public List<Job> GetJobs() 
        {
            return jobList;
        }

        public void DeleteJob(Job job)
        {
            Job JobExist=GetJobById(job.Id);
            if (JobExist != null) 
            {
                jobList.Remove(JobExist);
            }
        }  
    }
}
