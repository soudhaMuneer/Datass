using AutoMapper;
using JobPortalApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshopWithDB.DTO;
using RazorWorkshopWithDB.Interface;

namespace RazorWorkshopWithDB.Pages.Public
{
    public class RegisterModel : PageModel
    {
        private readonly IUserService  _userService;
        private readonly IMapper _mapper;

        public RegisterModel(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [BindProperty]
        public UserDto Input { get; set; }  

        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl ?? Url.Content("~/Public/Login");
            if(ModelState.IsValid)
            {
                var res = _userService.Register(_mapper.Map<User>(Input));
                if(res!=null)
                {
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Registration failed");
                }
                 
            }
            return Page();
        }
    }
}
