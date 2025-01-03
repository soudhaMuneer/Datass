using Exercise2.Interface;
using Exercise2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Exercise2.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly HireMeNowDbContext _context;
        public UserRepository(HireMeNowDbContext context)
        {
            _context = context;
        }
        public bool AddUser(User user)
        {
            var ExistingData= _context.Users.FirstOrDefault(x => x.Email == user.Email && x.UserName == user.UserName);
            if (ExistingData == null)
            {
                _context.Users.Add(user);
                _context.SaveChanges(); 
            }
            else
            {
                return false;
            }
            return true;
        }
        public User Login(string Email , string password)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == Email && x.Password == password);
            return user;
        }
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
