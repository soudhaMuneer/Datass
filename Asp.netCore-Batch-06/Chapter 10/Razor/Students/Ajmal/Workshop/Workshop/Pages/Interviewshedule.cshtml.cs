using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Workshop.Interfaces;
using Workshop.Models;
using Workshop.Services;

namespace Workshop.Pages
{
    public class InterviewsheduleModel : PageModel
    {
        //private readonly UserService InterviewService;
        
        //public InterviewsheduleModel(UserService userService)
        //{
        //    InterviewService = userService;
            
        //}

        public IActionResult OnGet()
        {
            return Page();
        }

        //[BindProperty]
        //public Interviews Interviews { get; set; } 

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    InterviewService.ScheduleInterview(Interviews);

        //    return RedirectToPage("./Index");
        //}
    }
}
