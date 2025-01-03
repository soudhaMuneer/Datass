using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor2ndActivity.Pages.Student1
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }
        public static List<Student> Students { get; set; }  = new List<Student>();
        public List<Student> Students1 { get; set; } = new List<Student>();
        public void OnGet()
        {
            Students1 = Students;
        }
        public void OnPost() {
            Students.Add(Student);
            Students1 = Students;

        }
    }
}
