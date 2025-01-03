using Exercise_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise_1.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public User Input { get; set; }
        public void OnGet()
        {
        }
    }
}
