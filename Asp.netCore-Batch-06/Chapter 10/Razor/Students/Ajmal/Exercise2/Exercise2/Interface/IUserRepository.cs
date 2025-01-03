using Exercise2.Models;

namespace Exercise2.Interface
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        List<User> GetUsers();
        User Login(string Email, string password);
    }
}
