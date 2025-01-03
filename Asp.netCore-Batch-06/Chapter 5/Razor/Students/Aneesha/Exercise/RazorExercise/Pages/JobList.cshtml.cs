using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Model;
using RazorExercise.Repoditory;

namespace RazorExercise.Pages
{
    public class JobListModel : PageModel
    {
        [BindProperty]
        public List<Job> jobs { get; set; }
        
        JobRepository repo = new JobRepository();
        [HttpGet]
        public IActionResult OnGet()
        {
            jobs = repo.GetJobs();
            return Page();
        }
        public void OnPost()
        {
            
        }
        
    }
}
