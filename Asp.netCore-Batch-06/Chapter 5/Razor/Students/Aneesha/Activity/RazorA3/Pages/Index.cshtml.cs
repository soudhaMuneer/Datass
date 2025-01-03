using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorA3.Pages
{
    public class IndexModel : PageModel
    {

        private static IndexModel _instance;
        private static readonly object _lockObject = new object();
        [BindProperty]

        public Person Input { get; set; }
        public static List<Person> Persons { get; set;} = new List<Person>();

        public IndexModel()
        {
            //this is private constructor to prevent instatiation outside the class
        }

        public static IndexModel Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock(_lockObject)
                    {
                        if (_instance == null)
                        {
                            _instance = new IndexModel();
                        }
                    }
                }
                return _instance;
            }
        }

        public void OnGet()
        {
            //initialize or load data if needed
        }

        public void OnPost()
        {
            if(ModelState.IsValid)
            {
                Persons.Add(Input);
            }
        }
    }
}
