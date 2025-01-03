using Exercise_1.Enum;
using Exercise_1.Models;

namespace Exercise_1.Reprostry
{
    public class UserReprostry
    {
        private List<User> userlist = new List<User>
        {
            new User(1,"Provider1",Role.Job_provide,"@Provider1")
        };

        public void Adduser(User user)
        {
            user.Role = Role.Job_seeker;
            userlist.Add(user);
        }

        public List<User> Getuserlist() 
        {
            return userlist;
        }
    }
}
