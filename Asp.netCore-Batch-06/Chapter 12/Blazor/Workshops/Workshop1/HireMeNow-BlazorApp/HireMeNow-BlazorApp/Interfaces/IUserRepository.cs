using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Interfaces
{
	public interface IUserRepository
	{
       public  void AddExperience(Experience experience, Guid guid);
       public void AddQualification(Qualification qualification, Guid guid);
        public void AddSkill(Skill skills, Guid guid);
        List<User> GetByFilter(string search, Roles role);
        User getById(Guid userId);
		User getuser();
	public	List<User> memberListing(Guid? companyId);
		void RemoveById(Guid id);
		User memberRegister(User user);
	public	List<User> jobseekerListing();

        List<User> jobProviderListing();
        User Login(string email, string password);
		void Logout();
        User register(User user);
        User Update(User user);
    }
}
