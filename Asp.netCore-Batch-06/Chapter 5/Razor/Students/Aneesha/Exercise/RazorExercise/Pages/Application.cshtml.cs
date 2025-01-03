using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Model;
using RazorExercise.Repository;

namespace RazorExercise.Pages
{
    public class ApplicationModel : PageModel
    {
        [BindProperty]
        public Application appp { get; set; }
        public List<Application> apps { get; set; } = new List<Application>();
   
        ApplicationRepository repository = new ApplicationRepository();

        public void OnGet()
        {
            apps = repository.GetApplications();
            
        }
        

        
    }
}
