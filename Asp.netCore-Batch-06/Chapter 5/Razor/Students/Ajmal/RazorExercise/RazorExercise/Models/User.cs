namespace RazorExercise.Models
{
	public class User
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public User(Guid id, string name, string email, string password)
		{
			Id = Guid.NewGuid();
			Name = name;
			Email = email;
			Password = password;
		}
		public User() { }
	}
}
