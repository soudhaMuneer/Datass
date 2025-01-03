using Workshop.Models;

namespace Workshop.Interfaces
{
    public interface IRegisterUser
    {
        User Adduser(User user);
        User Login(string Email, string password);
        List<User> Getuser();
    }
}
