using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IUserService
    {
      
        User login(string email, string password);
        User register(User user);
      
    }
}
