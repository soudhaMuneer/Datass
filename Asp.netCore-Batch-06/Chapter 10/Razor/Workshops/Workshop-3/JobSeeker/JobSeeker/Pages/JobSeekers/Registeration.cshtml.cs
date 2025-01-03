using JobSeeker.Managers;
using JobSeeker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace JobSeeker.Pages.JobSeekers
{
    public class RegisterationModel : PageModel
    {

        [BindProperty]
        public User Input { get; set; }


        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
        PublicService PublicService = new PublicService();
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/JobSeekers/Login");

            if (ModelState.IsValid)
            {
                var res = PublicService.RegisterJobSeeker(Input);
                if (res)
                    return LocalRedirect(returnUrl);
                else
                    ModelState.AddModelError(string.Empty, "Registration failed..");

            }

            return Page();
        }
    }
}
