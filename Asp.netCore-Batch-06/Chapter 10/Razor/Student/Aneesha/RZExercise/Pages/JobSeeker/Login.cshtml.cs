using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RZExercise.Dto;
using RZExercise.Interface;

namespace RZExercise.Pages.JobSeeker
{
    public class LoginModel : PageModel
    {
        private readonly IUserService publicService;
        private readonly IMapper _mapper;

        public LoginModel(IUserService publicService, IMapper mapper)
        {
            this.publicService = publicService;
            _mapper = mapper;
        }

        [BindProperty]
        public LoginDto Input { get; set; }
        public string Action {  get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            {
                var result = publicService.Login(Input.UserName, Input.Password);
                if(result != null)
                {
                    HttpContext.Session.SetString("UserId",result.UserId.ToString());
                    ViewData["UserId"]=result.UserId;
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
