using Microsoft.AspNetCore.Mvc;
using MVCpar.Models;

namespace MVCpar.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var people = new List<Person>
            {
                new Person {Name = "John", Age = 30},
                new Person {Name = "Alice", Age = 25},
                new Person {Name = "Bob", Age =35}

            };
            return View(people);
        }
    }
}
