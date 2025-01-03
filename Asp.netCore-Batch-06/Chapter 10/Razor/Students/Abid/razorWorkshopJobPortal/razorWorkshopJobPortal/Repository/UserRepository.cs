using razorWorkshopJobPortal.Enums;
using razorWorkshopJobPortal.Interfaces;
using razorWorkshopJobPortal.Models;



namespace razorWorkshopJobPortal.Repository
{
	public class UserRepository : IUserRepository
	{
		private jobportDbContext _context;
		public UserRepository(jobportDbContext context)
		{
			_context = context;
		}
		public User getById(Guid userId)
		{
			User user = _context.Users.Where(e=>e.Id==userId).FirstOrDefault();
			return user;
		}

		public User Login(string email, string password)
		{
			User log = _context.Users.Where(e=>e.Email==email && e.Password==password).FirstOrDefault();
			return log;
		}

		public User register(User user)
		{
			user.Role = Roles.JobSeeker.ToString();
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}


		public User getuser()
		{
			return _context.Users.FirstOrDefault();
		}
		public User Update(User updatedUser)
		{
			var userToUpdate = _context.Users.Find(updatedUser.Id);
			if (userToUpdate != null)
			{
				userToUpdate.About = updatedUser.About ?? userToUpdate.About;
				userToUpdate.FirstName = updatedUser.FirstName ?? userToUpdate.FirstName;
				userToUpdate.LastName = updatedUser.LastName ?? userToUpdate.LastName;
				userToUpdate.Location = updatedUser.Location ?? userToUpdate.Location;
				userToUpdate.Gender = updatedUser.Gender ?? userToUpdate.Gender;
				userToUpdate.Phone = updatedUser.Phone == null ? userToUpdate.Phone : updatedUser.Phone;


			}
			else
			{
				
			}

			return userToUpdate;
		}
		
		public List<User> getAllUsers()
		{
			return _context.Users.ToList();
		}

		
	}
}

