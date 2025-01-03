using RazorExercise.Interfaces;
using RazorExercise.Models;

namespace RazorExercise.Repositorys
{
	public class Jobrepository:IJob
	{

		public static List<Job> AllJobs = new List<Job>
		{
			new Job(1,"Software Developer","Dell","~/images/crypto-coin_14446117.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(2,"Python Developer","Dell", "~/images/j1.png","We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(3,"Front-end Developer","Dell","~/images/j2.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(4,".NET Developer","Dell","~/images/j3.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(5,"Angular Developer","Dell","~/images/j4.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(6,"PHP Developer","Dell","~/images/j5.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(7,"Django Developer","Dell","~/images/j6.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(8,"Flutter Developer","Dell","~/images/j7.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad"),
			new Job(9,"MEAN Stack Developer","Dell","~/images/j8.png", "We Are Hiring A Good Python Developer","25-07-3000","Palakkad")
		};
		public static List<Application> appliedjob = new List<Application>();

        private int _jobId;

        public void SetJobId(int jobId)
        {
            _jobId = jobId;
            Job apply = AllJobs.FirstOrDefault(s => s.Id == _jobId);
			Application application = new Application();
			application.Id = Guid.NewGuid();
			application.Jobtitle = apply.Jobtitle;
			application.Company= apply.Company;
			application.Description = apply.Description;
			application.Date= apply.Date;
			application.Location= apply.Location;
			application.image = apply.image;
			appliedjob.Add(application);	

          
        }
		public List<Application> GetAppliedJob()
		{
			
			return appliedjob;
		}
        public List<Job> GetJobs()
		{
			return AllJobs;
		}

	}
}
