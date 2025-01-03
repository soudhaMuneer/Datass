using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop2.Models;
using Workshop2.Services;

namespace Workshop2.Pages
{
    public class InterviewlistModel : PageModel
    {
        public List<Interview> Interviews { get; set; }=new List<Interview>();
        public Interviewslisting interview= new Interviewslisting();
        public void OnGet()
        {
            Interviews = interview.Interviews();
        }
    }
}
