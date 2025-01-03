using RazorExercise.Interfaces;
using RazorExercise.Models;
using RazorExercise.Repositorys;

namespace RazorExercise.Services
{
	public class Mainservice:IJob,IUser
	{
        public Jobrepository jobs = new Jobrepository();
       public UserRepository users = new UserRepository();
        

        public bool SetJobId(int jobId)
        {
            jobs.SetJobId(jobId);
            return true;
        }

        public List<Application> GetAppliedJob()
        {
            return jobs.GetAppliedJob();
        }
        public bool RegisterUser(User user)
        {
            
            users.RegisterUser(user);
            return true;
        }
        public List<User> GetUser()
        {
            return users.GetUser();
        }
        public List<Job> GetJobs()
        {
            return jobs.GetJobs();
        }
       
    }
}
