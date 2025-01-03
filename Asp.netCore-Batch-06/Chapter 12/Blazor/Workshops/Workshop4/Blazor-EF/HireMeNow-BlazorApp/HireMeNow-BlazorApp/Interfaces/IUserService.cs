using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IUserService
	{
		User login(string email, string password);
		void Addabout(string? about,Guid id);
		void AddExperience(Experience experience, Guid guid);
		void AddQualification(Qualification qualification, Guid guid);
		void AddSkill(Skill skills, Guid guid);
		User getById(Guid userId);
		User getLoggedUser();
        User register(User user);
        public List<User> GetByFilter(string search, Roles role);
        public List<User> jobseekerListing();
        public List<User> jobProviderListing();
        User Update(User user);
        void Logout();

	}
}
