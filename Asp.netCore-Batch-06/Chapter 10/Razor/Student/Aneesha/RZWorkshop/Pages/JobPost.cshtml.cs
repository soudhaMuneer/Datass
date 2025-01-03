using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RZWorkshop.DTO;
using RZWorkshop.Interface;
using RZWorkshop.Models;

namespace RZWorkshop.Pages
{
    public class JobPost(IJobService jobservice, IMapper mapper) : PageModel
    {
        private readonly IJobService jobservice = jobservice;
        private readonly IMapper mapper = mapper;


        [BindProperty]
        public JobDto Input { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl = null)
        {
            returnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPost(string returnUrl = null)
        {
            returnUrl = returnUrl;

            if(ModelState.IsValid)
            {
                Input.CompanyId = new Guid();
                var res = jobservice.PostJob(mapper.Map<Jobss>(Input));
                if(res != null)
                {
                    TempData["SuccessMessage"] = "Job posted successfully";
                    return RedirectToPage(returnUrl);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Job Post failed.");
                    return Page();
                }
            }
            return Page();
        }
    }
}
