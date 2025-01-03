using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Exceptions;
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
		public User LoggedUser = new User();
		bool _isLogged = false;
		public User login(string email, string password)
		{
			try
			{

				LoggedUser = userRepository.Login(email, password);
				if(LoggedUser==null) { return null; }
				if (LoggedUser.Email != null)
				{

					Console.WriteLine("Login successful!");
					_isLogged = true;
					Console.WriteLine("Welcome " + LoggedUser.FirstName);
					return LoggedUser;
				}
				else
				{
					Console.WriteLine("Login failed. Please try again.");
					return null;
				}
				
		}

			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				throw new ServiceException("technical error occured");
			}

		}
		public void Logout()
		{
			userRepository.Logout();
		}
        public User register(User user)
        {
            return userRepository.register(user);
        }
    }
}