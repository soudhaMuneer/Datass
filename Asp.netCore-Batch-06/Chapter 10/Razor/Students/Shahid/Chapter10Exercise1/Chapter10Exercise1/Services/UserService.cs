using Chapter10Exercise1.Interface;
using Chapter10Exercise1.Models;

namespace Chapter10Exercise1.Services
{
    public class UserService : IUserService
    {
        public IUserReprostry _userReprostry;
        public UserService(IUserReprostry userReprostry)
        {
            _userReprostry = userReprostry;

        }
        public Users register(Users user)
        {
            return _userReprostry.register(user);
            
        }
        public Users Login(string email ,  string password)
        {
            return _userReprostry.Login(email, password);
        }
    }
}
