using JobPost.Managers;
using JobPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace JobPost.Pages
{
    public class PostJobModel : PageModel
    {
        [BindProperty]
        public Job Input { get; set; }
        public string ReturnUrl { get; set; }
        JobPortal Jobs = new JobPortal();
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("/JobList");

            if (ModelState.IsValid)
            {
                var res = Jobs.PostJob(Input);
                if (res)
                    return LocalRedirect(returnUrl);
                else
                    ModelState.AddModelError(string.Empty, "Registration failed..");

            }

            return Page();
        }
    }
}
