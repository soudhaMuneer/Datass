using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
    public interface IUserService
    {
        User getById(Guid userId);
        User login(string email, string password);
        User register(User user);
        User Update(User user);
        List<User> getAllUsers();
		public List<User> jobseekerListing();
        public List<User> jobProviderListing();
        User getLoggedUser();
        void Logout();
    }
}
