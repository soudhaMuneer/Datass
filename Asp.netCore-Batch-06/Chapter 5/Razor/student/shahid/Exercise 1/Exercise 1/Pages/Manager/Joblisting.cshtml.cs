using Exercise_1.Models;
using Exercise_1.Reprostry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_1.Pages.Manager
{
    public class JoblistingModel : PageModel
    {
        
        public string dis = "disabled";
        private JobReprostry Jobreprostry = new JobReprostry();
        

        private Appliedjobreprostry Appliedjobreprostry= new Appliedjobreprostry();
        
        public List<Jobs> jobs = new List<Jobs>();
        
        public void OnGet()
        {
            jobs = Jobreprostry.GetJobs();
        }
        public void OnPost(int jobId)
        {
            jobs = Jobreprostry.GetJobs();
            foreach (var job in jobs) 
            {
                if(job.id == jobId)
                {
                    Jobs Job = job;
                    Console.WriteLine("job is "+Job.id);
                    Appliedjobreprostry.PostApplyjob(Job);
                  
                }
            }
            RedirectToPage("/Appliedjoblisting");

        }
    }
}
