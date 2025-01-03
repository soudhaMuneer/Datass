using AutoMapper;
using Chapter10Exercise1.Dtos;
using Chapter10Exercise1.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Chapter10Exercise1.Pages.Jobportal
{
    public class LoginModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public LoginModel(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [BindProperty]
        public LoginDto Login { get; set; }

        //public class InputModel
        //{
        //    [Required]
        //    [EmailAddress]
        //    public string Email { get; set; }

        //    [Required]
        //    [DataType(DataType.Password)]
        //    public string Password { get; set; }
        //}
        public async Task<IActionResult> OnPostAsync(string returnUrl = null) 
        {
            returnUrl = returnUrl ?? Url.Content("~/Jobportal/JobListing");
            var result = _userService.Login(Login.Email, Login.Password);
            if(result != null)
            {
                
                return LocalRedirect(returnUrl);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }
        }
        public void OnGet()
        {
        }
    }
}
