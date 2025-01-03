using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using HireMeNow_BlazorApp.Repositories;

namespace HireMeNow_BlazorApp.Services
{
    public class UserService : IUserService
    {
        public IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public User getById(Guid userId)
        {
            return userRepository.getById(userId);
        }
		public List<User> getAllUsers()
		{
			return userRepository.getAllUsers();
		}

		public User login(string email, string password)
        {
          return userRepository.Login(email,password);
        }

        public User register(User user)
        {
            return userRepository.register(user);
        }

        public User Update(User user)
        {
            var updateduser=userRepository.Update(user);
            return updateduser;
        }
		public List<User> jobseekerListing()
        {
			return userRepository.jobseekerListing();
		}
        public List<User> jobProviderListing()
        {
            return userRepository.jobProviderListing();
        }

        public User getLoggedUser()
        {
            return userRepository.getuser();
        }

		public void Logout()
		{
            userRepository.Logout();
		}
	}
}
