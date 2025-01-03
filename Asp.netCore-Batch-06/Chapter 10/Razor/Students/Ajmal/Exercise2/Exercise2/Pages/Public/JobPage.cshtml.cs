using AutoMapper;
using Exercise2.Interface;
using Exercise2.Models;
using Exercise2.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Exercise2.Pages.Public
{
    public class JobPageModel : PageModel
    {
        private readonly IJob jobService;
        private readonly IMapper mapper;

        public JobPageModel(IJob jobService, IMapper mapper)
        {
            this.jobService = jobService;
            this.mapper = mapper;
        }
        [BindProperty]
        public List<Job> jobs {  get; set; }= new List<Job>();
        public void OnGet()
        {
            jobs = jobService.ListJob();
        }
        //public async Task<IActionResult> OnPost(int id)
        //{

        //    string url = Url.Page("/Appliedjob");
        //    if (id != null)
        //    {
                
        //        if (res)
        //        {
        //            return LocalRedirect(url);
        //        }

        //        else
        //            ModelState.AddModelError(string.Empty, "Try Again To Apply");

        //    }

        //    return Page();


        //}

    }
}
