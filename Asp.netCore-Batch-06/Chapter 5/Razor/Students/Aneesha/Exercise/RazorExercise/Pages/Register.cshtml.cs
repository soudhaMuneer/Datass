using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using RazorExercise.Model;
using RazorExercise.Repository;

namespace RazorExercise.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User seeker { get; set; }
        public static List<User> user { get; set; } = new List<User>();
        public UserRepository userRepository { get; set; } =new UserRepository(); 
        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                userRepository.AddUser(seeker);
                Response.Redirect("/Login");
            }
          
        }
        public void OnGet()
        {
         
        }
    }
}
