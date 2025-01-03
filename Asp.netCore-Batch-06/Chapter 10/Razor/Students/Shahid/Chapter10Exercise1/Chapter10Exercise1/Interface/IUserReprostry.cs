using Chapter10Exercise1.Models;

namespace Chapter10Exercise1.Interface
{
    public interface IUserReprostry
    {
        public Users register(Users user);
        public Users Login(string email, string password);
    }
}
