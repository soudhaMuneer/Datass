using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IUserRepository
	{
       
		List<User> memberListing(Guid? companyId);
		void RemoveById(Guid id);
		User memberRegister(User user);
	
        User Login(string email, string password);
		void Logout();
        User register(User user);
      
    }
}
