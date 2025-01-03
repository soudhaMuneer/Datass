using Workshop.Enums;
using Workshop.Interfaces;
using Workshop.Models;

namespace Workshop.Repository
{
    public class UserRepository :IRegisterUser
    {
        private HireMeNowDbContext _Context;
        public UserRepository(HireMeNowDbContext context)
        {
            _Context = context;
        }



        public User Adduser(User user)
        {
            user.Role=Roles.JobProvider.ToString();
           _Context.Users.Add(user);
            _Context.SaveChanges();
            return user;
        }
       public User Login(string Email, string password)
        {
            var user=_Context.Users.FirstOrDefault(x => x.Email == Email && x.Password==password);
            return user;
        }
       public List<User> Getuser()
        {
            return _Context.Users.ToList();
        }
    }
}
