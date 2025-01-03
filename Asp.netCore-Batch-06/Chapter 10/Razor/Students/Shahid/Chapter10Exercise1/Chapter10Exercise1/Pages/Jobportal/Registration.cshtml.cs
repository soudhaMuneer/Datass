using AutoMapper;
using Chapter10Exercise1.Dtos;
using Chapter10Exercise1.Interface;
using Chapter10Exercise1.Models;
using Chapter10Exercise1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chapter10Exercise1.Pages.Jobportal
{
    public class RegistrationModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        public RegistrationModel(IUserService userService, IMapper mapper) 
        {
            _userService = userService;
            _mapper = mapper;
        }
        [BindProperty]
        public UserDto? Userdto { get; set; }
        

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/Jobportal/Login");


            if (ModelState.IsValid)
            {
                var res = _userService.register(_mapper.Map<Users>(Userdto));
                if (res != null)
                    return LocalRedirect(returnUrl);
                else
                    ModelState.AddModelError(string.Empty, "Registration failed..");

            }

            return Page();
        }


        public void OnGet()
        {
        }
    }
}
