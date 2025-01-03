﻿using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using HireMeNow_BlazorApp.Repositories;

namespace HireMeNow_BlazorApp.Services
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

        public List<Application> GetAll(Guid userId)
        {
            
                return _applicationRepository.GetAll(userId);
            
        }

        public List<Application> GetAllByCompany(Guid companyId)
        {
            return _applicationRepository.GetAllByCompany(companyId);
        }
    }
}
