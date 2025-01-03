namespace Exercise2.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public User() { }
        public User(string? name, string? userName, string? email, string? password)
        {
            Name = name;
            UserName = userName;
            Email = email;
            Password = password;
        }
    }
}
