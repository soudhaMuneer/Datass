using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop1.Services;

namespace Workshop1.Pages
{
    public class InterviewSheduleModel : PageModel
    {
        [BindProperty]
        public Interview input { get; set; }
        List<Interview> interviews=new List<Interview>();
        Interviewservice interviewservice = new Interviewservice();
        public void OnPost()
        {
            interviews.Add(input);
            interviewservice.ScheduleInterview(input);
            RedirectToPage("/InterviewShedule");
        }
        public void OnGet()
        {
        }
    }
}
