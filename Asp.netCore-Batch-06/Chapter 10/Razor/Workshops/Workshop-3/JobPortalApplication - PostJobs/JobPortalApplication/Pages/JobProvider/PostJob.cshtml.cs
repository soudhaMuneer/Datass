using AutoMapper;
using JobPortalApplication.Dtos;
using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;
using JobPortalApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobPortalApplication.Pages.JobProvider
{
    public class PostJobModel : PageModel
    {
        private readonly IJobService jobService;
        private readonly IMapper _mapper;

        public PostJobModel(IMapper mapper, IJobService _jobService)
        {
            jobService = _jobService;
            _mapper = mapper;
        }
        [BindProperty]
        public JobDto Input { get; set; }
        public string ReturnUrl { get; set; }
        public object companyId { get; set; }
        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            /*	 companyId = TempData["CompanyId"];
                TempData.Keep();*/
        }
        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl ?? "/JobProvider/JobsList"; // Use the page name without using Url.Content

            if (ModelState.IsValid)
            {
                // Hard-code this GUID in the database accordingly
                Input.CompanyId = new Guid("e02fd3d1-0e87-4f5d-ae1e-7f5aa1958773");
                var res = jobService.PostJob(_mapper.Map<Job>(Input));

                if (res != null)
                {
                    TempData["SuccessMessage"] = "Job posted successfully.";

                    // Use RedirectToPage with the page name
                    return RedirectToPage(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Job post failed.");
                    return Page();
                }
            }

            return Page();
        }



    }
}