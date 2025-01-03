using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Workshop.DTOs;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Services;

namespace Workshop.Pages
{
    public class RegisterModel : PageModel
    {
       
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public RegisterModel(IUserService service,IMapper mapp)
        {
            userService = service;
            mapper = mapp;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public UserDtos UserDtos { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var urls = Url.Content("~/Login");
            if (ModelState.IsValid)
            {
                var res = userService.Adduser(mapper.Map<User>(UserDtos));
                if (res!=null)
                {
                    return LocalRedirect(urls);
                }
            }
            return Page();
        }
    }
}
