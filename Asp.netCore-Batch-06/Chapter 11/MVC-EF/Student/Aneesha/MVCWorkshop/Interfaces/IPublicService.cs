using MVCWorkshop.Models;

namespace MVCWorkshop.Interfaces
{
    public interface IPublicService
    {
        public User LoginJobSeeker(string email, string password);
        public User Register(User newJobseeker);
        public User RegisterAdmin(User user);
    }
}
