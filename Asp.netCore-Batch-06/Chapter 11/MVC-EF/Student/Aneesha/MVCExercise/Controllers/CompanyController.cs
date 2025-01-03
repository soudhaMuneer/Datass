using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVCExercise.Dto;
using MVCExercise.Interface;
using MVCExercise.Models;

namespace MVCExercise.Controllers
{
    public class CompanyController : Controller
    {
        public readonly ICompanyService _companyService;
        IMapper mapper;
        
        public CompanyController(ICompanyService companyService,IMapper _mapper)
        {
            _companyService = companyService;
            mapper = _mapper;
        }

        public ActionResult Registration(Company company)
        {
            if (ModelState.IsValid) 
            {
                _companyService.Registration(company);
                TempData["message"] = "Registration succesffull";
               return RedirectToAction("ViewCompanyProfile");
            }
            return View();
        }
        
        public ActionResult ViewCompanyProfile(Company company)
        {
            _companyService.ViewCompanyProfile(company);
            CompanyDto  cdto = mapper.Map<CompanyDto>(company); 
            return View(cdto);
        }
        public IActionResult GetCompanyById(int id)
        {
            _companyService.GetCompanyById(id);
            return View();
        }
    }


}
//HttpContext: This is an object provided by ASP.NET Core that encapsulates all HTTP-specific information about an individual HTTP request.
//HttpContext.Session represents the session state for the current HTTP request. 
//SetString is a method provided by the ISession interface It is used to store a string value in the session state.