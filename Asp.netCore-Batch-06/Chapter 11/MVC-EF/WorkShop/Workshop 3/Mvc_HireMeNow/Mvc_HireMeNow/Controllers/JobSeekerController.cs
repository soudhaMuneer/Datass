
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mvc_HireMeNow.Dtos;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;
using System.Collections.Generic;

namespace Mvc_HireMeNow.Controllers
{
	public class JobSeekerController : Controller
	{
		IJobService _jobService;
		IUserService _userService;
		
		IApplicationService _applicationService;
		IMapper mapper;
		public JobSeekerController(IJobService jobService, IUserService userService, IApplicationService applicationService, IMapper _maper)
        {
			_jobService = jobService;
			_userService = userService;
		
			_applicationService = applicationService;
			mapper=_maper;
		}
		public List<Job> jobs { get; set; } = new List<Job>();
		public IActionResult Alljobs(Guid?selectedJobId = null)
		{

			jobs = _jobService.GetJobs();

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
			if (jobId != null)
			{
				var uid = HttpContext.Session.GetString("UserId");

				_applicationService.AddApplication( new Guid(uid), new Guid(jobId));


				return RedirectToAction("MyApplications");

			}
			return RedirectToAction("AllJobs");
			
		}
		public IActionResult Profile()
		{
			var uid = HttpContext.Session.GetString("UserId");
			User user = _userService.getById(new Guid(uid));
			UserProfileDto userProfileDto = mapper.Map<UserProfileDto>(user);
			return View(userProfileDto);
		}
		
		
		

	}
}
