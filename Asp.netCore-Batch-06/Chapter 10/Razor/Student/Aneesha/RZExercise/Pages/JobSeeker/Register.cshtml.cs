using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RZExercise.Dto;
using RZExercise.Interface;
using System.Runtime.CompilerServices;

namespace RZExercise.Pages.JobSeeker
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public RegisterModel(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [BindProperty]
        public UserDto Input { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl=null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl ?? Url.Content("~/JobSeeker/Logn");
            if(ModelState.IsValid)
            {
                var res = _userService.register(_mapper.Map<UserDto>(Input));
                if (res != null)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Registration Failed");
                }
            }
            return Page();
        }
    }
}
