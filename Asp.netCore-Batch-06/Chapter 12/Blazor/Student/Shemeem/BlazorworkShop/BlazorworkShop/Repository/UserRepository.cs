using System;
using BlazorworkShop.Enums;
using BlazorworkShop.Exceptions;
using BlazorworkShop.Interface;
using BlazorworkShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorworkShop.Repository
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


        public User memberRegister(User user)
        {
            user.Id = Guid.NewGuid();
            user.Role = Roles.CompanyMember; ;
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

        public List<User> memberListing(Guid? companyId)
        {
            var memberList = _context.Users.Where(e => e.Role == Roles.CompanyMember && e.CompanyId == companyId).ToList();
            return memberList;
        }
        public List<User> jobseekerListing()
        {
            var memberList = _context.Users.Where(e => e.Role == Roles.JobSeeker).ToList();
            return memberList;
        }
        public List<User> jobProviderListing()
        {
            var memberList = _context.Users.Where(e => e.Role == Roles.JobProvider).ToList();
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

        public void AddSkill(Skill skills, Guid guid)
        {
            _context.Skills.Add(skills);
            _context.SaveChanges();
        }

        public void AddExperience(Experience experience, Guid guid)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
        }

        public void AddQualification(Qualification qualification, Guid guid)
        {
            _context.Qualifications.Add(qualification);
            _context.SaveChanges();
        }

        public User Update(User user)
        {

            var userToUpdate = _context.Users.FirstOrDefault(u => u.Id == user.Id);

            if (userToUpdate != null)
            {
                userToUpdate.FirstName = user.FirstName ?? userToUpdate.FirstName;
                userToUpdate.LastName = user.LastName ?? userToUpdate.LastName;
                userToUpdate.Email = user.Email ?? userToUpdate.Email;
                userToUpdate.Gender = user.Gender ?? userToUpdate.Gender;
                userToUpdate.Phone = userToUpdate.Phone;
                userToUpdate.Image = user.Image ?? userToUpdate.Image;
                userToUpdate.About = user.About ?? userToUpdate.About;
                _context.SaveChanges();
                return userToUpdate;
            }
            return userToUpdate;
        }
        public void RemoveById(Guid id)
        {
            User user = _context.Users.Where(e => e.Id == id).FirstOrDefault();
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
    }

}

