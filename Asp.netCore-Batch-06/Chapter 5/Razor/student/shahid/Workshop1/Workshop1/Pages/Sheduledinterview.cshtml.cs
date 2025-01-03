using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop1.Services;

namespace Workshop1.Pages
{
    public class SheduledinterviewModel : PageModel
    {
        Interviewservice interviewservice = new Interviewservice();
        public List<Interview> Interviewss =new List<Interview>();
        public void OnGet()
        {
            Interviewss = interviewservice.GetInterviews();
        }
    }
}
