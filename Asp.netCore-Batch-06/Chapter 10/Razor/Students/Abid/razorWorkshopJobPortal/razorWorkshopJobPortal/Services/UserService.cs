using razorWorkshopJobPortal.Interfaces;
using razorWorkshopJobPortal.Models;
using razorWorkshopJobPortal.Repository;

namespace razorWorkshopJobPortal.Services
{
	public class UserService : IUserService
	{
		public IUserRepository Userrepository;

		public UserService(IUserRepository _userRepository)
		{
			Userrepository = _userRepository;
		}

		public User getById(Guid userId)
		{
			return Userrepository.getById(userId);
		}
		public User login(string email, string password)
		{
			return Userrepository.Login(email, password);
		}
		public User register(User user)
		{
			return Userrepository.register(user);
		}
		
		public User Update(User user)
		{
			var updateduser = Userrepository.Update(user);
			return updateduser;
		}
		public List<User> getAllUsers()
		{
			return Userrepository.getAllUsers();
		}
	}
}
