using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models;

namespace HireMeNow_MVC_Application.Services
{
	public class UserService : IUserService
	{
		public IUserRepository userRepository;
		
		public UserService(IUserRepository _userRepository)
		{
			userRepository = _userRepository;
			
		}
	

	
		public User GetById(Guid id)
		{
			return userRepository.getById(id);
		}

        User IUserService.updateUserProfile(User updatedUser)
        {
            return userRepository.updateUserProfile(updatedUser);
        }
    }
}
