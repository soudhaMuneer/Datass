using Microsoft.AspNetCore.Mvc;
using MvcUtube.Models;

namespace MvcUtube.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            ViewData["message"] = "view data message";
            ViewBag.newMessage = "This is a new message";

            var student = new List<Studentcs>
            {
                new Studentcs
                {
                    Id = 1,
                    Name="Haneesha",
                    Marks = 99
                },
                new Studentcs
                {
                    Id=2,
                    Name = "Ani",
                    Marks = 80
                },
                new Studentcs
                {
                    Id=3,
                    Name = "Anu",
                    Marks = 30
                }
            };
            return View(student);
        }
    }
}
