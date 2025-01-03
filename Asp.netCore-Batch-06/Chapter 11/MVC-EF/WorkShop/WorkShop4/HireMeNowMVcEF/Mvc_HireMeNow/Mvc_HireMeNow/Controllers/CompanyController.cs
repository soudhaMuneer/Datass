using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Mvc_HireMeNow.Dtos;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;
using Mvc_HireMeNow.Services;

namespace Mvc_HireMeNow.Controllers
{
	public class CompanyController : Controller
	{

		private readonly ICompanyService _companyService;
		public readonly IUserRepository _userRepository;
		public readonly IUserService _userService;
		IMapper _mapper;
		private readonly ICompanyRepository _companyRepository;
		public CompanyController(ICompanyService companyService, IMapper mapper, ICompanyRepository companyRepository, IUserRepository userRepository,IUserService userService)
		{
			_companyService = companyService;
			_mapper = mapper;
			_companyRepository = companyRepository;
			_userRepository = userRepository;
			_userService = userService;
		}
		[HttpGet]
		public ActionResult CompanyRegistration()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult CompanyRegistration(CompanyDto companyDto)
		{
			try
			{
				if (_companyRepository.IsUserExist(companyDto.Name))
				{
					return BadRequest("Company Already Exist");
				}
				else
				{
					Company company = _mapper.Map<Company>(companyDto);

				Company comp=	_companyService.Register(company);
                    var uid = HttpContext.Session.GetString("UserId");
                    User user = _userService.GetById(new Guid(uid));
					user.CompanyId = comp.Id;

					_userRepository.UpdateProfile(user);
                    TempData["message"] = "added successfully";

					return View();

				}

			}
			catch
			{
				return View();
			}
		}
		public IActionResult Index()
		{
			return View();
		}




		



	}

}
