using Chapter10Exercise1.Models;

namespace Chapter10Exercise1.Interface
{
    public interface IUserService
    {
        public Users register(Users user);
        public Users Login (string email , string password);
    }
}
