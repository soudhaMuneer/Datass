using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorWorkshopWithDB.Interface;
using System.ComponentModel.DataAnnotations;

namespace RazorWorkshopWithDB.Pages.Public
{
    public class LoginModel : PageModel
    {
        private readonly IUserService publicService;
        private readonly IMapper _mapper;

        public LoginModel(IUserService Userservice, IMapper mapper)
        {
            publicService = Userservice;
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

       
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            {
                var result = publicService.Login(Input.Email, Input.Password);
                if (result != null)
                {
                    HttpContext.Session.SetString("UserId",result.Id.ToString());
                    ViewData["UserId"] = result.Id;
                    ViewData["UserId"]= result.Id;
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
