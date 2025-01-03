using RazorExercise.Model;

namespace RazorExercise.Repoditory
{
    public class JobRepository
    {
        public  static List<Job> jobs { get; set; } = new List<Job>
        {
            new Job(1,"Software Engineer","Angular,.Net,Agile methodology,cloud computing","Dubai","onsite",3500),
            new Job(2,"Developer","Angular,.Net","Abudhabi","onsite",3000),
            new Job(3,"Sales Excecutive","Managment","Sharja","onsite",2000),
            new Job(4,"Accounting","Taly","Dubai","onsite",2500),
            new Job(5,"Data Scientist","Big Data","Dubai","onsite",4000)

        };

        public void PostJob(Job job)
        {
            job.Id = jobs.Count + 1;
            jobs.Add(job);
            
        }
        public List<Job> GetJobs()
        {
            return jobs;
        }
        public Job getJobById(int id)
        {
            return jobs.FirstOrDefault(e => e.Id == id);
        }
    }
}
