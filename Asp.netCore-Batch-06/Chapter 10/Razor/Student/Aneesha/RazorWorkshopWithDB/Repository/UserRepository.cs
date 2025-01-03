using JobPortalApplication.Models;
using RazorWorkshopWithDB.Enums;
using RazorWorkshopWithDB.Interface;
using RazorWorkshopWithDB.Model;

namespace RazorWorkshopWithDB.Repository
{
    public class UserRepository : IUserRepository
    {
        public HireMeNowDBContext _context;

        public UserRepository(HireMeNowDBContext context)
        {
            _context = context;
        }
         public User GetById(Guid id)
        {
            User user = _context.Users.Where(e => e.Id == id).FirstOrDefault();
            return user;
        }
        public User Login(string email, string password)
        {
            User log = _context.Users.Where(e=>e.Email == email && password == password).FirstOrDefault();
            return log;
        }

        public User Register(User user)
        {
            user.Role = Roles.JobSeeker.ToString();
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User Update(User updateuser)
        {
            var update = _context.Users.Find(updateuser.Id);
            if (update == null)
            {
                update.FirstName = updateuser.FirstName ?? updateuser.FirstName;
                update.LastName = updateuser.LastName ?? updateuser.LastName;
                update.Email = updateuser.Email ?? updateuser.Email;
                update.Gender = updateuser.Gender ?? updateuser.Gender;
                update.Location = updateuser.Location ?? updateuser.Location;
                update.Phone = updateuser.Phone ?? updateuser.Phone;
                update.Password = updateuser.Password ?? updateuser.Password;
                update.Role = Roles.JobSeeker.ToString();
                update.About = updateuser.About ?? updateuser.About;
                update.Designation = updateuser.Designation ?? updateuser.Designation;
                update.Status = updateuser.Status ?? updateuser.Status;
                update.CreatedDate = DateTime.Now;  
            }
            
            return update;

        }

        public User Getuser()
        {
            return _context.Users.FirstOrDefault();
        }

       
        
        
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
            
        }

        


    }
}
