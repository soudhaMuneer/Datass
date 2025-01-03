using Microsoft.AspNetCore.Mvc;

namespace RazorExercise.Models
{
    public class Binding
    {
        [BindProperty]
        public string password { get; set; }
        [BindProperty]
        public string name { get; set; }
    }
}
