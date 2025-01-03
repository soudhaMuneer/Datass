using AutoMapper;
using Exercise2.DTOs;
using Exercise2.Interface;
using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Policy;

namespace Exercise2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IUserService UserService;
        private readonly IMapper mapper;
        public IndexModel(IUserService _UserService, IMapper _mapper)
        {
            UserService = _UserService;
            mapper = _mapper;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserDtos User { get; set; } = new UserDtos();

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var urls = Url.Content("~/Public/LoginPage");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var res = UserService.AddUser(mapper.Map<User>(User));
            if (res != null)
            {
                return LocalRedirect(urls);
            }

            return RedirectToPage("./Index");
        }
       
    }
}
