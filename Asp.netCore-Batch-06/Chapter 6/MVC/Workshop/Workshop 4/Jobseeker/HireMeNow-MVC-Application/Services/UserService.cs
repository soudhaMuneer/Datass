using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models;

namespace HireMeNow_MVC_Application.Services
{
	public class UserService : IUserService
	{
		public IUserRepository userRepository;
		public IJobRepository jobRepository;
		public UserService(IUserRepository _userRepository, IJobRepository _jobRepository)
		{
			userRepository = _userRepository;
			jobRepository=_jobRepository;
		}
		public bool ApplyJob(Guid jobid, Guid userId)
		{
			return userRepository.ApplyJob(jobid, userId);
			
		}

		

		public User GetById(Guid id)
		{
			return userRepository.getById(id);
		}

      
    }
}
