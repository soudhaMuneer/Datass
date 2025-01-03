using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Exercise_2.Models;
using System.Threading.Tasks;
using Exercise_2.Enums;
using Exercise_2.Expectations;

namespace Exercise_2.Repository
{
    public class UserRepository
    {
        private List<User> users = new List<User>()
        {
             new User(2, "Lal", "Krishna", "admin@gmail.com", 123, "123", Roles.JobProvider), new User(2, "Raj", "Ram", "jobProvider@gmail.com", 123, "123", Roles.JobProvider)
        };
        private int nextId = 1;
        public User WhosLogingin(string email , string password) 
        {
            var user = users.FirstOrDefault(e => e.Email == email && e.Password == password);
            return user;
        }
        public bool register(User user)
        {
            user.Id = nextId;
            user.Role = Roles.JobSeeker;
            nextId++;
            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistException(user.Email);
        }
    }
}
