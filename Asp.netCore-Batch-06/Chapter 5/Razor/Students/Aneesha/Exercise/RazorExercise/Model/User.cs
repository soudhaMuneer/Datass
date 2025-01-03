namespace RazorExercise.Model
{
	public class User
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string UserName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

		public User(string username,string email,string password)
		{
			UserName = username;
			Email = email;
			Password = password;

		}

		public User() { }
	}

	
}
