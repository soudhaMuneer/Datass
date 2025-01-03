using RazorExercise.Models;

namespace RazorExercise.Interfaces
{
	public interface IUser
	{
		bool RegisterUser(User user);
		List<User> GetUser();
	}
}
