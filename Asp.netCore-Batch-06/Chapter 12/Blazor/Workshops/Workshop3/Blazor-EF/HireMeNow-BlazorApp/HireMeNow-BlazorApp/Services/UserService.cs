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
		public void Addabout(string? about, Guid id)
		{
			throw new NotImplementedException();
		}

		public void AddExperience(Experience experience, Guid guid)
		{
			userRepository.AddExperience(experience, guid);	
		}

		public void AddQualification(Qualification qualification, Guid guid)
		{
			userRepository.AddQualification(qualification,guid);
		}
        //public List<User> getAllUsers()
        //{
        //	return userRepository.getAllUsers();
        //}

		public void AddSkill(Skill skills, Guid guid)
		{
            userRepository.AddSkill(skills, guid);
        }

        public User GetById(Guid guid)
		{
			throw new NotImplementedException();
		}

		public User login(string email, string password)
		{
			try
			{

				LoggedUser = userRepository.Login(email, password);
				if (LoggedUser==null) return null;
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

		public User getLoggedUser()
		{
			return userRepository.getuser();
		}

		public void Logout()
		{
			userRepository.Logout();
		}

		public User getById(Guid userId)
		{
			return userRepository.getById(userId);
		}

        public User Update(User user)
        {
            var updateduser = userRepository.Update(user);
            return updateduser;
        }

        public List<User> GetByFilter(string search, Roles role)
        {
            return userRepository.GetByFilter(search, role);
        }

        public List<User> jobseekerListing()
        {
            return userRepository.jobseekerListing();
        }

        public List<User> jobProviderListing()
        {
            return userRepository.jobseekerListing();
        }

        public User register(User user)
        {
            return userRepository.register(user);
        }
    }
}