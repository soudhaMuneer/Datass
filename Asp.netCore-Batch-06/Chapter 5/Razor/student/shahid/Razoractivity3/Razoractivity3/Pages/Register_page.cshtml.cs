using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razoractivity3.Model;

namespace Razoractivity3.Pages
{
    public class Register_pageModel : PageModel
    {
        [BindProperty]
        public People formdata { get; set; }
        public static List<People> peoples = new List<People>();
        public  List<People> peoples1 = new List<People>();
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid) {
                peoples.Add(formdata);
                peoples1 = peoples;
                return Page();
            }
            else
            {
                return RedirectToPage("Error");
            }
            
        }
    }
}
