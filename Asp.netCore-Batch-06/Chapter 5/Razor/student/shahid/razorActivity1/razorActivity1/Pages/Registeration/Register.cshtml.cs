using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorActivity1.Model;

namespace razorActivity1.Pages.Registeration
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Student student { get; set; }
        public static List<Student> studentlist { get; set; } = new List<Student>();


        public List<Student> studentlist1 { get; set; }
        public void OnGet()
        {
            studentlist1 = studentlist;
        }
        public void OnPost()
        {
            studentlist.Add(student);
            studentlist1 = studentlist;
        }
    }
}
