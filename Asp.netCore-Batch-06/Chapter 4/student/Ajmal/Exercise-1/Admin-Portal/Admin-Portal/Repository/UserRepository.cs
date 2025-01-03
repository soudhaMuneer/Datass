using Admin_Portal.Interface;
using Admin_Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Repository
{
    public class UserRepository:IUserRepository
    {
        public static List<User> Users = new List<User>();
        private int userid = 1;
        public bool Newuser(User user)
        {
            user.Id = userid;
            userid++;
            if (user != null)
            {
               Users.Add(user);
            }
            return true;
        }
       
       public List<User> Getuser()
        {
            return Users;
        }
        public User login(string email, string password)
        {
            return Users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }
    }
}
