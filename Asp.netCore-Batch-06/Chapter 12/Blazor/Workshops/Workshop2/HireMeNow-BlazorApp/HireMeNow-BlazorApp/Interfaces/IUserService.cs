using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IUserService
	{
		User login(string email, string password);
	
        User register(User user);
        
        void Logout();

	}
}
