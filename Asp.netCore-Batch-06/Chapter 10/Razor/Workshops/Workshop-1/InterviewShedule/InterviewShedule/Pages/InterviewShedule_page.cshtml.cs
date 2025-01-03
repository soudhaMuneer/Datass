using InterviewShedule.Models;
using InterviewShedule.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InterviewShedule.Pages
{
    public class InterviewShedule_pageModel : PageModel
    {
        [BindProperty]
        public Interview Input { get; set; }
        public string ReturnUrl { get; set; }
        InterviewService interview= new InterviewService();
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("/SheduledInterview");

            if (ModelState.IsValid)
            {
                var res = interview.ScheduleInterview(Input);
                if (res)
                    return LocalRedirect(returnUrl);
                else
                    ModelState.AddModelError(string.Empty, "Registration failed..");

            }

            return Page();
        }
    }
}
