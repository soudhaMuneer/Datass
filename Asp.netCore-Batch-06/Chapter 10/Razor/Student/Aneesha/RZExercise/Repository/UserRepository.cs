using RZExercise.DAL;
using RZExercise.Exceptions;
using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Repository
{
    public class UserRepository : IUserRepo
    {
        private SeekerDBContext _dbContext;
        public User user = new User();
        public List<User> users = new List<User>();

        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
        public void UpdateUser(Guid id)
        {
            var user = _dbContext.Users.FirstOrDefault(e=>e.UserId == id);
            if (user != null)
            {
                user.FullName = user.FullName;
                user.UserName = user.UserName;
                user.Email = user.Email;
                user.Password = user.Password;
                user.Location = user.Location;
                user.Gender = user.Gender;
                user.Phone = user.Phone;
                user.Qualification = user.Qualification;
                
            }
            

            else
            {
                throw new ItemNotFoundException("User not found");
            }
        }
        public void DeleteUser(Guid id)
        {
            var remove = _dbContext.Users.FirstOrDefault(e=>e.UserId == id);    
            if (remove != null)
            {
                _dbContext.Remove(remove);
            }
        }
        public User GetById(Guid id)
        {
            User userss =  _dbContext.Users.Where(e => e.UserId == id).FirstOrDefault();
            return userss;
            
        }
        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

        public User Login(string userName, string password)
        {
            User res = _dbContext.Users.Where(e=>e.UserName==userName && e.Password==password).FirstOrDefault();
            return res;
        }
        public User register(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();   
            return user;
        }
    }
}
