using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Exceptions;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Models;

namespace HireMeNow_BlazorApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        HireMeNowDbContext _context = new HireMeNowDbContext();
       

       
        private static User loggedUser = new User();
        public UserRepository(HireMeNowDbContext context)
        {
            _context = context;
        }
        public User Login(string email, string password)
        {
            loggedUser = _context.Users.Where(e => e.Email == email && e.password == password).FirstOrDefault();
			return loggedUser;
		}

        public User register(User user)
        {
            user.Id = Guid.NewGuid();
            user.Role = Roles.JobSeeker; ;
            var userallready = _context.Users.FirstOrDefault(e => e.Email == user.Email);

            if (userallready == null)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return user;
            }
            else
            {
                throw new UserAlreadyExistException(user.Email);
            }
        }

       
       
        public List<User> jobseekerListing()
        {
            var memberList = _context.Users.Where(e => e.Role == Roles.JobSeeker).ToList();
            return memberList;
        }


       

        public User getuser()
		{
			return loggedUser;
		}



		public void Logout()
		{
			loggedUser = null;
		}
        public List<User> GetByFilter(string search, Roles role)
        {
            var memberList = _context.Users.Where(e => (e.Role == role) && e.FirstName.Contains(search, StringComparison.OrdinalIgnoreCase)).ToList();
            return memberList;
        }


        public User getById(Guid userId)
		{
			User user = _context.Users.Where(e => e.Id == userId).Include(x => x.Skills)
				.Include(x => x.Experiences)
				.Include(x => x.Qualifications).IgnoreAutoIncludes().FirstOrDefault();
			return user;
		}

        void IUserRepository.AddExperience(Experience experience, Guid guid)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.AddQualification(Qualification qualification, Guid guid)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.AddSkill(Skill skills, Guid guid)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.memberListing(Guid? companyId)
        {
            throw new NotImplementedException();
        }

        void IUserRepository.RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        User IUserRepository.memberRegister(User user)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.jobProviderListing()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}