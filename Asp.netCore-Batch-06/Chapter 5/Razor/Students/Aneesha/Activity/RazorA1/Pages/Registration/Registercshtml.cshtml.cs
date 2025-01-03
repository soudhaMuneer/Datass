using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorA1.Model;

namespace RazorA1.Pages.Registration
{
    public class RegistercshtmlModel : PageModel
    {
        [BindProperty]

        public Student student {  get; set; }
        public static List<Student> studentslist { get; set;} = new List<Student>();

        public List<Student> Studentslist1 { get; set; }

        public void OnGet()
        {
            Studentslist1 = studentslist;
        }

        public void OnPost() 
        { 
            studentslist.Add(student);
            Studentslist1 = studentslist;
        }
        
    }
}
