using Exercise_1.Models;

namespace Exercise_1.Reprostry
{
    public class JobReprostry
    {
        private static List<Jobs> jobs { get; set; } = new List<Jobs>
        {
    new Jobs(1,"Software Engineer","Angular,.Net,Agile methodology,cloud computing","Dubai","onsite",3500),
    new Jobs(2,"Developer","Angular,.Net","Abudhabi","onsite",3000),
    new Jobs(3,"Sales Excecutive","Managment","Sharja","onsite",2000),
    new Jobs(4,"Accounting","Taly","Dubai","onsite",2500),
    new Jobs(5,"Data Scientist","Big Data","Dubai","onsite",4000)
        };

        public List<Jobs> GetJobs()
        {
            return jobs;
        }
        public void PostJob(Jobs job)
        {
            jobs.Add(job);
        }
    }
}
