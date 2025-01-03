using AutoMapper;
using HireMeNowWebApi.Dtos;
using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;
using HireMeNowWebApi.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HireMeNowWebApi.Controllers
{
	[Route("api/Jobs")]
	[ApiController]
	public class JobController : ControllerBase
	{

		private readonly IJobService _jobService;
		private readonly IMapper _mapper;
        // GET: api/<JobController>
        public JobController(IJobService jobService, IMapper mapper )
        {
			 _jobService= jobService;
			_mapper= mapper;

		}
        [HttpGet("/job/GetJobList")]

		public IActionResult GetJob()
		{
			List<Job> job = _jobService.GetJobs();
			return Ok(job);
		}
		
		[HttpPost("/job/PostJob")]
		public IActionResult PostJob(JobDto jobDto)
		{
			var job = _mapper.Map<Job>(jobDto);
			return Ok(_jobService.PostJob(job));
			
			
		}	
	}
}
