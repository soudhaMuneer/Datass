using JobPost.Managers;
using JobPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace JobPost.Pages
{
    public class JobListModel : PageModel
    {
        [BindProperty]
        public List<Job> jobs { get; set; } 
        JobPortal Jobs = new JobPortal();
        public void OnGet()
        {
            jobs = Jobs.GetJobs();
        }
		public IActionResult OnPostRemoveJob(int id)
		{
			jobs = Jobs.GetJobs();
			var jobToRemove = jobs.FirstOrDefault(job => job.Id == id);
			if (jobToRemove != null)
			{
				jobs.Remove(jobToRemove);
			}
			return Page();
		}
	}
}
