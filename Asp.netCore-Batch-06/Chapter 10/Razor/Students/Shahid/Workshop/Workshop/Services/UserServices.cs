using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Services
{
    public class UserServices : IUserService
    {
        public IUserReprosetry userRepository;
        public UserServices(IUserReprosetry _userRepository)
        {
            userRepository = _userRepository;
                
        }
      
        public User register(User user)
        {
            return userRepository.register(user);
        }
    }
}
