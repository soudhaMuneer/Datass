using Exercise2.Interface;
using Exercise2.Models;
using Exercise2.Repositories;

namespace Exercise2.Services
{
    public class UserService: IUserService
    {
      
       
        private readonly IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
       

        public bool AddUser(User user)
        {
            userRepository.AddUser(user);

            return true;
        }
        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }
        public User Login(string Email, string password)
        {
         return userRepository.Login(Email, password);

        }
    }
}
