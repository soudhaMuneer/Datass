using MVCWorkshop.Models;

namespace MVCWorkshop.Interfaces
{
    public interface IUserRepository
    {
        User getById(Guid userId);
        User getLoggedUser();
        List<User> JobSeekerListing();
        User login(string email, string password);
        User register(User user);
        User registerAdmin(User user);
        User UpdateProfile(User updatedAdmin);
    }
}
