using InterviewShedule.Models;
using InterviewShedule.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewShedule.Pages
{
	public class SheduledInterviewModel : PageModel
	{
		[BindProperty]

		public List<Interview> Interviews { get; set; } = new List<Interview>();
		InterviewService interview = new InterviewService();
		public void OnGet()
        {
			Interviews = interview.GetInterviews();

		}
    }
}
