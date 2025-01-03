using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshop4.Models;
using RazorWorkshop4.Services;

namespace RazorWorkshop4.Pages
{
    public class PostJobModel : PageModel
    {
        [BindProperty] //This attribute is used to bind the form data from the Razor Page to the Input property automatically when a POST request is made.
        public Job jb {  get; set; } //This is the model that will hold the job details submitted by the user.
        
        public string ReturnUrl { get; set; } //This property will hold the URL to redirect to after the job is posted.

		JobPortal portal = new JobPortal();
		public void OnGet(string returnUrl = null)
        {
            //This method is called on HTTP GET requests.
            //It takes an optional returnUrl parameter and assigns it to the ReturnUrl property.
            //This is used to determine where to redirect the user after a successful job post.
            ReturnUrl = returnUrl;

        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("/JobList");

            if (ModelState.IsValid)
            {
                var res = portal.PostJob(jb);
                if (res)
                    return LocalRedirect(returnUrl);
                else 
                    ModelState.AddModelError(string.Empty, "Registration Failed");
            }
            return Page();
        }
    }
}
