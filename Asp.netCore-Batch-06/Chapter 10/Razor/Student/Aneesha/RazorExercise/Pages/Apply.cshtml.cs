using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Model;
using RazorExercise.Repository;

namespace RazorExercise.Pages
{
    public class ApplyModel : PageModel
    {
        public bool ApplyFailed { get; set; }
        [BindProperty]
        public Application application { get; set; }
        public List<Application> applications { get; set; } = new List<Application>();
        public string ReturnUrl { get; set; }
        ApplicationRepository AppRepo { get; set; } = new ApplicationRepository();
        public async  Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("/Application");
           if (ModelState.IsValid)
            {
                var res = AppRepo.AddApplication(application);
                if (res)
                    return LocalRedirect(returnUrl);
                else
                    ModelState.AddModelError(string.Empty, "Registration failed");
            }
           return Page();

        }
           
        public void OnGet()
        {
            applications = AppRepo.GetApplications();
        }

        private List<Application> GetApplications()
        {
            return new List<Application>();
        }

        }

        
        
    }

