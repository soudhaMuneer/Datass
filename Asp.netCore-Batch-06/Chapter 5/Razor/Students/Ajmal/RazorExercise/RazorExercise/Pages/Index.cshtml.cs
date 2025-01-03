using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Models;
using RazorExercise.Services;

namespace RazorExercise.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }
        private readonly ILogger<IndexModel> _logger;
        
        Mainservice Mainservice = new Mainservice();
        public string Returnurl { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet(string url=null)
        {
            Returnurl = url;
        }
        public async Task<IActionResult> OnPost(string url=null)
        {
            url = url ?? Url.Page("/Seeker_Login");
            
            if (ModelState.IsValid)
            {
               var inp = Mainservice.RegisterUser(user);
                if (inp)
                {
                    return LocalRedirect(url);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Registration failed..");
                }
            }
            return Page();
        }
    }
}
