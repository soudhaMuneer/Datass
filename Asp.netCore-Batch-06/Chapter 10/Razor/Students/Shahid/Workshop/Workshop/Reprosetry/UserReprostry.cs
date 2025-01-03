using Workshop.Enums;
using Workshop.Exeption;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Reprosetry
{
    public class UserReprostry : IUserReprosetry
    {
        private JobPortalDbContext _context;

        public UserReprostry(JobPortalDbContext context)
        {
            _context = context;
        }
        //public User getById(Guid userId)
        //{
        //    User user = _context.Users.Where(e => e.Id == userId).FirstOrDefault();
        //    return user;
        //}

        //public User Login(string email, string password)
        //{
        //    User res = _context.Users.Where(e => e.Email == email && e.Password == password).FirstOrDefault();
        //    return res;

        //}
        public User register(User user)
        {

            user.Role = Roles.JobSeeker.ToString();
            _context.Users.Add(user);
            _context.SaveChanges();


            return user;
        }
        //public User Update(User updatedUser)
        //{
        //    var userToUpdate = _context.Users.Find(updatedUser.Id);
        //    if (userToUpdate != null)
        //    {
        //        // Modify the properties of the item at the found index
        //        userToUpdate.About = updatedUser.About ?? userToUpdate.About;
        //        //userToUpdate.Experiences = updatedUser.Experiences ?? userToUpdate.Experiences;
        //        //_context.Users[indexToUpdate].Educations = updatedUser.Educations ??userToUpdate.Educations;
        //        // userToUpdate.Skills = updatedUser.Skills ?? userToUpdate.Skills;
        //        userToUpdate.FirstName = updatedUser.FirstName ?? userToUpdate.FirstName;
        //        userToUpdate.LastName = updatedUser.LastName ?? userToUpdate.LastName;
        //        userToUpdate.Location = updatedUser.Location ?? userToUpdate.Location;
        //        userToUpdate.Gender = updatedUser.Gender ?? userToUpdate.Gender;
        //        userToUpdate.Phone = updatedUser.Phone == null ? userToUpdate.Phone : updatedUser.Phone;
        //    }
        //    else
        //    {
        //        throw new NotFoundException("User Not Found");
        //    }


        //    return userToUpdate;
        //}

    }
}
