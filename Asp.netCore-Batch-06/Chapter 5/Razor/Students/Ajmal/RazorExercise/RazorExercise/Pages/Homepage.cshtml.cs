using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Models;
using RazorExercise.Services;
using System;

namespace RazorExercise.Pages
{
    public class HomepageModel : PageModel
    {
        [BindProperty]
        public List<Job> jobs { get; set; }=new List<Job>();
        
       
        public Mainservice mainservice = new Mainservice();
        public void OnGet()
        {
            jobs=mainservice.GetJobs();
        }
        //public void OnPost()
        //{
           
                
        //     RedirectToAction("/Appliedjob");
        //    //jobs = mainservice.GetJobs();
        //    //var jobToapply = jobs.FirstOrDefault(job => job.Id == id);
        //    //if (jobToapply != null)
        //    //{

        //    //}
           
        //}
        public async Task<IActionResult> OnPost(int id)
        {

            string url = Url.Page("/Appliedjob");
            if (id!=null)
            {
                var res = mainservice.SetJobId(id); 
                if (res)
                {
                    return LocalRedirect(url);
                }

                else
                    ModelState.AddModelError(string.Empty, "Try Again To Apply");

            }

            return Page();


        }
    }

}

