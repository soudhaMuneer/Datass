using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IPublicService
	{
		public User LoginJobSeeker(string email, string password);
		public User Register(User newJobSeeker);
	}
}
