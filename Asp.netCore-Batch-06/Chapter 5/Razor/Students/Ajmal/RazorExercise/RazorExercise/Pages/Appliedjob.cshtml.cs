using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Models;
using RazorExercise.Services;
using System.Reflection;

namespace RazorExercise.Pages
{
    public class AppliedjobModel : PageModel
    {

        //public Job AppliedJob { get; set; }
        [BindProperty]
        public List<Application> Jobs { get; set; }
        public Mainservice mainservice=new Mainservice();
        public void OnGet()
        {
            // Sample job list. Replace with actual data source.
            //int jobid=mainservice.GetJobId();
            //AppliedJob = Jobs.FirstOrDefault(job => job.Id == jobid);
            Jobs= mainservice.GetAppliedJob();

        }
    }
}
