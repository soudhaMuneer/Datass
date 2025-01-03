using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.ComponentModel.DataAnnotations;
using Workshop.DTOs;
using Workshop.Interfaces;
using Workshop.Models;

namespace Workshop.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;
        public LoginModel(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }
        [BindProperty]
        public InputModel login {  get; set; }= new InputModel();
        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPost(string url = null)
        {
            url = Url.Content("~/Interviewshedule");
            if (login != null)
            {
                if (ModelState.IsValid)
                {
                    var res = userService.Login(login.Email, login.Password);
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
