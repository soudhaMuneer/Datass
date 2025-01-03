using Microsoft.AspNetCore.Mvc;
using MVC_Paartial_view.Models;

namespace MVC_Paartial_view.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            // Sample data
            var people = new List<Person>
            {
                new Person { Name = "John", Age = 30 },
                new Person { Name = "Alice", Age = 25 },
                new Person { Name = "Bob", Age = 35 }
            };

            return View(people);
        }
    }

    
}

