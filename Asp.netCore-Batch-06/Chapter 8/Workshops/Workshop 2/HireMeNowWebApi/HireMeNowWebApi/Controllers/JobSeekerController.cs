using AutoMapper;
using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;
using HireMeNowWebApi.Repositories;
using HireMeNowWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Eventing.Reader;

namespace HireMeNowWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class JobSeekerController : ControllerBase
	{
	
		IJobService _jobService;
		IUserService _userService;
		IUserRepository _userRepository;
		IApplicationService _applicationService;
		private readonly IMapper _mapper;
		public JobSeekerController(IJobService jobService, IUserService userService, IUserRepository userRepository, IApplicationService applicationService)
		{
			
			_jobService = jobService;
			_userService = userService;
			_userRepository = userRepository;
			_applicationService = applicationService;
			
		}


        [HttpGet("/job/GetJobList")]
        public IActionResult GetJob()
        {
            List<Job> job = _jobService.GetJobs();
            return Ok(job);
        }
        [HttpPost("/JobSeeker/ApplyJob")]
		public IActionResult ApplyJob(ApplicationDto applicationDto)
		{
			

			var Job=_jobService.getJobById(applicationDto.JobId.Value);
			var cmp = _userService.getById(applicationDto.UserId.Value);
			if(Job==null || cmp==null)
			{
				return BadRequest("Not valid.");
			}

				
			_applicationService.AddApplication(applicationDto.JobId.Value,applicationDto.UserId.Value);
			return Ok();

		

			
			
		}
		[HttpGet("/JobSeeker/AllApplyJobs")]
		public IActionResult AllAppliedJobs()
		{
						//HttpContext.Session.SetString("UserId", result.Id.ToString());
			List<Application> Application = _applicationService.AllAppliedjobs();

		
			return Ok(Application);
		}
		
	}

}
