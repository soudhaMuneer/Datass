using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshop4.Models;
using RazorWorkshop4.Services;

namespace RazorWorkshop4.Pages
{
    public class JobListModel : PageModel
    {
        [BindProperty]
        public List<Job> jobs { get; set; }

         JobPortal portal = new JobPortal();

        public void OnGet()
        {
          jobs = portal.GetJobs();
        }
        public IActionResult OnPostRemoveJob(int id)
        {
            jobs = portal.GetJobs();
            var jobToRemove = jobs.FirstOrDefault(x => x.Id == id);
            if(jobToRemove != null)
            {
                jobs.Remove(jobToRemove);
            }
            return Page();
        }
    }
}
