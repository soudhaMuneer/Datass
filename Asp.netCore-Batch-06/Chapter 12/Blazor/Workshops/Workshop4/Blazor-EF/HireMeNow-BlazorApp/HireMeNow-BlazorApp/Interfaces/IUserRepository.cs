using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IUserRepository
	{
        void AddExperience(Experience experience, Guid guid);
        void AddQualification(Qualification qualification, Guid guid);
        void AddSkill(Skill skills, Guid guid);
        List<User> GetByFilter(string search, Roles role);
        User getById(Guid userId);
		User getuser();
		List<User> memberListing(Guid? companyId);
		void RemoveById(Guid id);
		User memberRegister(User user);
		List<User> jobseekerListing();

        List<User> jobProviderListing();
        User Login(string email, string password);
		void Logout();
        User register(User user);
        User Update(User user);
    }
}
