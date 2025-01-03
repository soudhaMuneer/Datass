using HireMeNow_MVC_Application.Models;

namespace HireMeNow_MVC_Application.Interfaces
{
	public interface IUserService
	{
		User GetById(Guid id);
	
		
		public User updateUserProfile(User updatedUser);

    }
}
