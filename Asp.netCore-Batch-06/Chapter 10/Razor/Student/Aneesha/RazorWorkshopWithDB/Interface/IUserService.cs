using JobPortalApplication.Models;

namespace RazorWorkshopWithDB.Interface
{
    public interface IUserService
    {
        User GetById(Guid userId);
        User Login(string email, string password);
        User Register(User user);
        User Update(User updateuser);
        List<User> GetAllUsers();
      
    }
}
