using RazorExercise.Interfaces;
using RazorExercise.Models;

namespace RazorExercise.Repositorys
{
	public class UserRepository:IUser
	{
		public static List <User> Users = new List<User> {new User (new Guid(),"ajmal","aj@gmail.com","123" )};
		
		public bool RegisterUser(User user)
		{
			user.Id = Guid.NewGuid();
			Users.Add(user);
			return true;
		}
		public List<User> GetUser()
		{
			return Users;
		}
	}
}
