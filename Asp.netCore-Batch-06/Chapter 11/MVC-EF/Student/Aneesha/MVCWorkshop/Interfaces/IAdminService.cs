using MVCWorkshop.Models;

namespace MVCWorkshop.Interfaces
{
    public interface IAdminService
    {
        User getLoggedUser();
        List<User> JobSeekerListing();
        User LoginAdmin(string username, string password);
        User UpdateProfile(User updatedAdmin);
    }
}
