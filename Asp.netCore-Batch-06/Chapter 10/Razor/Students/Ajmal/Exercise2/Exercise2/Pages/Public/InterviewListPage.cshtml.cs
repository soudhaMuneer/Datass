using AutoMapper;
using Exercise2.Interface;
using Exercise2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise2.Pages.Public
{
    public class InterviewListPageModel : PageModel
    {
        private readonly IInterview interviewService;
        private readonly IMapper mapper;

        public InterviewListPageModel(IInterview interviewService, IMapper mapper)
        {
            this.interviewService = interviewService;
            this.mapper = mapper;
        }
        [BindProperty]
        public List<Interview> interviews { get; set; } = new List<Interview>();
        public void OnGet()
        {
            interviews=interviewService.GetInterviews();
        }
    }
}
