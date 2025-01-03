using Exercise_1.Enum;

namespace Exercise_1.Models
{
    public class User
    {
        int Id { get; set; }

        string Username { get; set; }

        public Role Role { get; set; }
        string Password { get; set; }

        public User() { }

        public User(int id, string username, Role role,string password) 
        {
            Id = id;
            Username = username;
            Role = role;
            Password = password;

        }
    }
}
