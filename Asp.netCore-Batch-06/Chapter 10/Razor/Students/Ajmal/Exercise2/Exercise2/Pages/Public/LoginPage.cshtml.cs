using AutoMapper;
using Exercise2.DTOs;
using Exercise2.Interface;
using Exercise2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Security.Policy;

namespace Exercise2.Pages.Public
{
    public class LoginPageModel : PageModel
    {
        private readonly IUserService _userService;
        private readonly IMapper mapper;
        public LoginPageModel(IUserService userService, IMapper _mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }
        [BindProperty]
        public LoginDtos userDtos { get; set; }=new LoginDtos();
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPost(string url=null)
        {
            url = Url.Content("~/Public/JobPage");
            if (userDtos != null)
            {
                if (ModelState.IsValid)
                {
                    var res = _userService.Login(userDtos.Email, userDtos.Password);
                    if (res != null)
                    {
                        return LocalRedirect(url);
                    }
                }
            }
            return Page();
        }
    }
}
