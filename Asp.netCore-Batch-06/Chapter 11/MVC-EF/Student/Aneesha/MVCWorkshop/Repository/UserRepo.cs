using Microsoft.EntityFrameworkCore;
using MVCWorkshop.Enums;
using MVCWorkshop.Interfaces;
using MVCWorkshop.Models;
using System.Data.Entity;

namespace MVCWorkshop.Repository
{
    public class UserRepo : IUserRepository
    {
        private JobPortalDbContext _context;
        private static User loggedUser = new User();
        public UserRepo(JobPortalDbContext context)
        {
            _context = context;
        }
        public User getById(Guid userId)
        {
            User user = _context.Users.Where(e => e.Id == userId).Include(x => x.Skills)
                .Include(x => x.Experiences)
                .Include(x => x.Qualifications).IgnoreAutoIncludes().FirstOrDefault();
            return user;
        }

        public User getLoggedUser()
        {
            return loggedUser;
        }

        public List<User> JobSeekerListing()
        {
            return _context.Users.Where(e => e.Role == Roles.JobSeeker).ToList();
        }
        public User login(string email, string password)
        {
            loggedUser = _context.Users.Where(e => e.Email == email && e.Password == password).FirstOrDefault();
            return loggedUser;
        }
        public User register(User user)
        {
            user.Role = Enums.Roles.Admin;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User registerAdmin(User user)
        {
            user.Role = Enums.Roles.Admin;
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User UpdateProfile(User updatedAdmin)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.Id == updatedAdmin.Id);

            if (userToUpdate != null)
            {
                userToUpdate.FirstName = updatedAdmin.FirstName ?? userToUpdate.FirstName;
                userToUpdate.LastName = updatedAdmin.LastName ?? userToUpdate.LastName;
                userToUpdate.Email = updatedAdmin.Email ?? userToUpdate.Email;
                userToUpdate.Phone = userToUpdate.Phone;
                _context.SaveChanges();
                return userToUpdate;
            }
            return userToUpdate;
        }
    }
}
