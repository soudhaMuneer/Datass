using Workshop.Models;

namespace Workshop.Interfaces
{
    public interface IUserService
    {
        User Adduser(User user);
        User Login(string Email, string password);
        List<User> Getuser();
    }
}
