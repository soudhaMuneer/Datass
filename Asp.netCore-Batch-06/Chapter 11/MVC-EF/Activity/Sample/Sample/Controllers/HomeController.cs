using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using System.Diagnostics;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Action method sample
        public IActionResult Sample()
        {

            ViewData["message"] = "view data message";
            ViewBag.newMessage = "This is a new message";
            /*created an instance of student class
            Student s=new Student();
            s.Id = 1;
            s.Name = "Afra";
            s.Marks = 80;

            return View(s);*/
            var student = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "afra",
                    Marks = 36
                },
                new Student
                {
                    Id = 2,
                    Name = "heizel",
                    Marks = 40
                },
                new Student
                {
                    Id = 3,
                    Name = "hafiz",
                    Marks = 45
                }
            };
            return View(student);
        }
    }
}
