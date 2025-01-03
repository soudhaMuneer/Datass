using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RZExercise.Models;
using RZExercise.Repository;

namespace RZExercise.Pages.JobSeeker
{
    public class JobListModel : PageModel
    {
        private readonly JobRepository jobRepository;
        public JobListModel(JobRepository jobRepository)
        {
            this.jobRepository = jobRepository;
        }

        [BindProperty]
        public List<Job> Jobs { get; set; }
        public void OnGet()
        {
            Jobs = jobRepository.jobs.ToList();
        }
    }
}
