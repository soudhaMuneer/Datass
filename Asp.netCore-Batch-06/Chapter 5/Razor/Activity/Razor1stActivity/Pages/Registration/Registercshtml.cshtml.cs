using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor1stActivity.Model;

namespace Razor1stActivity.Pages.Registration
{
    public class RegistercshtmlModel : PageModel
    {
        [BindProperty]
        public Student student {  get; set; }
        public static List<Student> studentlist { get; set; }=new List<Student>();      


        public  List<Student> studentlist1 { get; set; }
        public void OnGet()
        {
            studentlist1 = studentlist;
        }
        public void OnPost() {
            studentlist.Add(student);
            studentlist1 = studentlist;
        }
    }
}
