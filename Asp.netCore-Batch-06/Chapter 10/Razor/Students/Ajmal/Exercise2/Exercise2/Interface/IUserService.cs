using Exercise2.Models;

namespace Exercise2.Interface
{
    public interface IUserService
    {
        bool AddUser(User user);
        User Login(string Email, string password);
        List<User> GetUsers();
    }
}
