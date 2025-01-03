using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using razorWorkshopJobPortal.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace razorWorkshopJobPortal.Pages.Public
{
    public class LoginModel : PageModel
    {
        

        private readonly IUserService publicService;

        private readonly IMapper _mapper;

        public LoginModel(IUserService userService, IMapper mapper)
        {
            publicService = userService;
            _mapper = mapper;

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string Action { get; set; }


        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }

        public IActionResult OnGet(string Action = null)
        {

           
            return Page();

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/Public/Register");

            if (ModelState.IsValid)
            {
                var result = publicService.login(Input.Email, Input.Password);
                if (result != null)
                {
                    //HttpContext.Session.SetString("UserId", result.Id.ToString());
                    //HttpContext.Session.SetString("CompanyId", result.CompanyId.ToString());
                    //ViewData["UserId"] = result.Id;
                    //TempData["UserId"] = result.Id;
                    //TempData["CompanyId"] = result.CompanyId;

                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            return Page();
        }
    }
    }

