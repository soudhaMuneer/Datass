using RazorExercise.Model;

namespace RazorExercise.Repository
{
    public class UserRepository
    {
        public static List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User Login(string email, string password) 
        { 
            var loggedUser=users.Where(e=>e.Email==email && e.Password == password).FirstOrDefault();
            return loggedUser;

        }
    }
}
