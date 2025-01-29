﻿using HireMeNowWebApi.Interfaces;
using HireMeNowWebApi.Models;
using HireMeNowWebApi.Repositories;

namespace HireMeNowWebApi.Services
{
	public class ApplicationService : IApplicationService
	{
		public IUserRepository _userRepository;
		public  IJobRepository _jobRepository;
		public IApplicationRepository _applicationRepository;
        public ApplicationService(IUserRepository userRepository, IJobRepository jobRepository, IApplicationRepository applicationRepository)
        {
			_userRepository = userRepository;
			_jobRepository = jobRepository;
			_applicationRepository = applicationRepository;

		}
        public void AddApplication(Guid JobId, Guid UserId)
		{
			User user=_userRepository.getById(UserId);
			Job job = _jobRepository.GetJobById(JobId);
			
			_applicationRepository.AddApplication(user,job);
		}
		public List<Application> AllAppliedjobs()
		{


			return _applicationRepository.AllAppliedjobs();
		}
		public List<Application> AllAppliedJobsByUserIdorCompanyID(Guid? UserId = null, Guid? CmpId = null)
		{
			return _applicationRepository.AllAppliedJobsByUserIdorCompanyID(UserId, CmpId);
		}
	}
}
