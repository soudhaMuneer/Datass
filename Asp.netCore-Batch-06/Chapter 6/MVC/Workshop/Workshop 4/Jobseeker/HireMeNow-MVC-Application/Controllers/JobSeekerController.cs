﻿using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models;
using HireMeNow_MVC_Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_MVC_Application.Controllers
{
    public class JobSeekerController : Controller
    {
        IJobService _jobService;
        IUserService _userService;
		IUserRepository _userRepository;
		IApplicationService _applicationService;
		public JobSeekerController(IJobService jobService, IUserService userService,IUserRepository userRepository,IApplicationService applicationService)
        {
            _jobService=jobService;
            _userService=userService;
			_userRepository=userRepository;
			_applicationService=applicationService;
        }
        public IActionResult AllJobs(Guid? selectedJobId =null)
		{
			
			List<Job> jobs = _jobService.GetJobs();

			Job selectedJob = new Job();
			selectedJob = jobs.FirstOrDefault(new Job());
			if (selectedJobId != null)
			{
				selectedJob = _jobService.getJobById(selectedJobId.Value);

			}

			ViewBag.selectedJob = selectedJob;
			return View(jobs);
        }
        [HttpPost]
		public IActionResult ApplyJob(string jobId = null)
        {
            if (jobId!=null)
            {
				var uid = HttpContext.Session.GetString("UserId");
				
				_applicationService.AddApplication(new Guid(jobId), new Guid(uid));

			
                    return RedirectToAction("MyApplications");
                

			}
			return RedirectToAction("AllJobs");
		}

		

		public IActionResult Profile()
		{
			var uid = HttpContext.Session.GetString("UserId");
			User user = _userService.GetById(new Guid(uid));
			return View(user);
		}
		



    }
}
