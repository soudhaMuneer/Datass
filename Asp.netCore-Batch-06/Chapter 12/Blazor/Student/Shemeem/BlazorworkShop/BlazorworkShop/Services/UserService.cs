using System;
using BlazorworkShop.Exceptions;
using BlazorworkShop.Interface;
using BlazorworkShop.Models;

namespace BlazorworkShop.Services
{
	public class UserService:IUserService
	{
		public IUserRepository UserRepository;
		public UserService(IUserRepository _userRepository)
		{
			UserRepository = _userRepository;
		}
		public User LoggedUser = new User();
		bool isLoged = false;
		public User login(string email, string password)
		{
			try
			{
				LoggedUser = UserRepository.Login(email, password);
				if (LoggedUser == null) { return null; }
				if(LoggedUser.Email != null)
				{
                    Console.WriteLine("Login successful!");
                    isLoged = true;
                    Console.WriteLine("Welcome " + LoggedUser.FirstName);
                    return LoggedUser;

                }
				else
				{
                    Console.WriteLine("Login failed. Please try again.");
                    return null;
                }

			}
			catch(Exception ex)
			{
                Console.WriteLine(ex.Message);
                throw new ServiceException("technical error occured");
            }

		}
		public void Logout()
		{
            UserRepository.Logout();
        }
		public User register(User user)
		{
            return UserRepository.register(user);
        }
    }
}

