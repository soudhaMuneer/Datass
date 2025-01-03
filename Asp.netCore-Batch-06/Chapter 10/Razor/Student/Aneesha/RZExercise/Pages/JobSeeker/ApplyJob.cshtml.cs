using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RZExercise.Dto;
using RZExercise.Interface;

namespace RZExercise.Pages.JobSeeker
{
    public class ApplyJobModel : PageModel
    {
        private readonly IJobService jobService;
        private readonly IMapper _mapper;

        public ApplyJobModel(IJobService jobService, IMapper mapper)
        {
            this.jobService = jobService;
            _mapper = mapper;
        }
        [BindProperty]
        public ApplyDto Input { get; set; }
        public string ReturnUrl { get; set; }
       
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl;
        }
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? "/JobSeeker/SheduleInterview";
            if (ModelState.IsValid)
            {
                var res = jobService.ApplyForJob(_mapper.Map<ApplyDto>(Input));
            }
        }
    }
}
