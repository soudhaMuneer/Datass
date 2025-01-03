using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorExercise.Models;
using RazorExercise.Services;

namespace RazorExercise.Pages
{
    public class Seeker_LoginModel : PageModel
    {
        [BindProperty]
        public Binding BindProperty { get; set; }   

        public List<User> Login { get; set; }
        Mainservice Mainservice = new Mainservice();
        public string Returnurl { get; set; }
        public void OnGet(string url = null)
        {
            Returnurl = url;
        }
        public async Task<IActionResult> OnPost(string url = null)
        {
            url=url ?? Url.Page("/Homepage");

            if (ModelState.IsValid)
            {
                var res = Mainservice.GetUser().FirstOrDefault(x => x.Name == BindProperty.name && x.Password == BindProperty.password);
                
                if (res != null) { 
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
