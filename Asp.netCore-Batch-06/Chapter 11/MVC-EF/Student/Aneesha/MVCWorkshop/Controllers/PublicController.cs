using Microsoft.AspNetCore.Mvc;
using MVCWorkshop.Interfaces;
using MVCWorkshop.Models;

namespace MVCWorkshop.Controllers
{
    public class PublicController : Controller
    {
        private readonly IPublicService _publicService;
        public PublicController(IPublicService publicService)
        {
            _publicService = publicService;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(User user)
        {
            try
            {
                _publicService.Register(user);

                return RedirectToAction("Login");




            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        // GET:  PublicController
        public ActionResult Registration()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            try

            {
                var result = _publicService.LoginJobSeeker(email, password);
                if (result != null)
                {
                    HttpContext.Session.SetString("UserId", result.Id.ToString());
                    HttpContext.Session.SetString("CompanyId", result.CompanyId.ToString());
                    return View("Registration");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }

            }
            catch
            {
                return View();
            }
        }
    }
}

