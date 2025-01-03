using JobPortalApplication.Models;
using RazorWorkshopWithDB.Interface;
using RazorWorkshopWithDB.Repository;

namespace RazorWorkshopWithDB.Services
{
    public class UserService : IUserService
    {
        
        public IUserRepository userRepository;
        public UserRepository use;
        public UserService(IUserRepository _userrepository)
        {
            userRepository = _userrepository;
        }
        public User GetById(Guid userId)
        {
            return use.GetById(userId);
        }
        public User Login(string email, string password)
        {
            return use.Login(email, password);
        }

        public User Register(User user)
        {
            return use.Register(user);
        }
         
        public User Update(User user)
        {
            var updateduser = use.Update(user);
            return updateduser;
        }
        public List<User> GetAllUsers()
        {
            return use.GetAllUsers();
        }
    }
}
