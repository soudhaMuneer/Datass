using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Workshop2.Interface;
using Workshop2.Models;
using Workshop2.Services;

namespace Workshop2.Pages
{
    public class ScheduleInterviewModel : PageModel
    {
        [BindProperty]
        public Interview Interview { get; set; } 

        public string Returnurl { get; set; }

        Interviewslisting Interviewslisting = new Interviewslisting();
        public void OnGet(string url=null)
        {
            Returnurl= url;
        }
        public async Task<IActionResult> OnPost ()
        {
            
          string url =  Url.Page("/interviewlist");
            if (ModelState.IsValid)
            {
                var res = Interviewslisting.SheduleInterview(Interview);
                if (res)
                {
                    return LocalRedirect(url);
                }

                else
                    ModelState.AddModelError(string.Empty, "Registration failed..");

            }

				return Page();


			}
        }
    }

