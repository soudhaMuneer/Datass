

using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Enums;
using Mvc_HireMeNow.Exceptions;
using Mvc_HireMeNow.Interfaces;
using Mvc_HireMeNow.Models;
using System;

namespace Mvc_HireMeNow.Repositories
{
	public class UserRepository : IUserRepository
	{
		private HireMeNowDbContext _context;
		private static User loggedUser = new User();
		public UserRepository(HireMeNowDbContext context)
		{
			_context = context;
		}

		public User login(string email, string password)
		{
			loggedUser = _context.Users.Where(e => e.Email == email && e.password == password).FirstOrDefault();
			return loggedUser;
		}

		public User register(User user)
		{
			user.Role = Roles.JobSeeker;
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}
		public User registerAdmin(User user)
		{
            user.Role = Roles.Admin;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
		public User getById(Guid userId)
		{
			User user = _context.Users.Where(e => e.Id == userId).Include(x => x.Skills)
				.Include(x => x.Experiences)
				.Include(x => x.Qualifications).IgnoreAutoIncludes().FirstOrDefault();
			return user;
		}




		public User getLoggedUser()
		{
			return loggedUser;
		}

		public List<User> JobSeekerListing()
		{
			return _context.Users.Where(e => e.Role == Roles.JobSeeker).ToList();
		}

		public User UpdateProfile(User updatedAdmin)
		{
			var userToUpdate = _context.Users.FirstOrDefault(u => u.Id == updatedAdmin.Id);

			if (userToUpdate != null)
			{
				userToUpdate.FirstName = updatedAdmin.FirstName ?? userToUpdate.FirstName;
				userToUpdate.LastName = updatedAdmin.LastName ?? userToUpdate.LastName;
				userToUpdate.Email = updatedAdmin.Email ?? userToUpdate.Email;
				userToUpdate.Phone = userToUpdate.Phone;
				_context.SaveChanges();
				return userToUpdate;
			}
			return userToUpdate;
		}
		
	}
}
