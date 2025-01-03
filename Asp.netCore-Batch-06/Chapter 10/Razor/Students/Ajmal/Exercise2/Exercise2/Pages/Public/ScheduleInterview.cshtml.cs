using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Exercise2.Models;
using Exercise2.DTOs;
using AutoMapper;
using Exercise2.Interface;

namespace Exercise2.Pages.Public
{
    public class ScheduleInterviewModel : PageModel
    {
        private readonly IInterview interview;
        private readonly IMapper mapper;
        public ScheduleInterviewModel(IInterview _interview, IMapper _mapper)
        {
            interview = _interview;
            mapper = _mapper;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InterviewDtos interviewDtos { get; set; } = new InterviewDtos();

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var urls = Url.Content("~/Public/InterviewListPage");
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var res = interview.ScheduleInterview(mapper.Map<Interview>(interviewDtos));
            if (res != null)
            {
                return LocalRedirect(urls);
            }

            return Page();
        }
    }
}
