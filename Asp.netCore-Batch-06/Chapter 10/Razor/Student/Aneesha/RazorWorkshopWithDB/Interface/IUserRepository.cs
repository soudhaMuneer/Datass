using JobPortalApplication.Models;

namespace RazorWorkshopWithDB.Interface
{
    public interface IUserRepository
    {
        public interface IUserRepository
        {
            User GetById(Guid userId);
            User Login(string email, string password);
            User Register(User user);
            User GetUser();
            User Update(User updateUser);
            List<User> GetAllUsers();
           
        }
    }
}
