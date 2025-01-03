using Exercise3.Enums;
using Exercise3.Exceptions;
using Exercise3.Interface;
using Exercise3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Repository
{
    public sealed class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User> { new User(1, "provider1","Google", "pro1@gmail.com", "123", "12345678", Roles.JobProvider), 
                                                    new User(2, "provider2","Google", "pro2@gmail.com", "122", "12345678", Roles.JobProvider),
                                                    new User(2, "provider3","Google", "pro3@gmail.com", "124", "12345678", Roles.JobProvider),
                                                    new User(1, "provider1","Google", "pro4@gmail.com", "125", "12345678", Roles.JobProvider)};

        public static List<Application> applications = new List<Application> { new Application(1, "Haneesha","RH","Aneesha1@gmail.com","1234567890","India","23 years old MCA greduate","BCA,MCA,FullStack","Fullstack"),
                                                                         new Application(1, "aneesha","Jamal","Aneesha2@gmail.com","1234567891","India","23 years old MCA greduate","BCA,MCA,FullStack","Fullstack"),
                                                                         new Application(1, "Anisha","Ani","Aneesha3@gmail.com","1234567892","India","23 years old MCA greduate","BCA,MCA,FullStack","Fullstack"),
                                                                         new Application(1, "Hanee","Anee","Aneesha4@gmail.com","1234567893","India","23 years old MCA greduate","BCA,MCA,FullStack","Fullstack")
                                                                                                                                                                                                                      };

        public static User loggedUser = new User();
        public int nextId = 2;
        public string email;

        public List<User> GetAll()
        {
            return users.Where(e => e.Role == Roles.JobProvider).ToList();
        }
        public bool register(User user)
        {
            user.Id = nextId;
            user.Role = Roles.JobProvider;
            nextId++;
            if(users.Find(e => e.Email == user.Email) == null )
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistException(user.email);
        }

        
        public User login(string email, string password)
        {
            return users.FirstOrDefault(e => e.Email == email && e.Password == password);
        }

        public List<Application> GetApplications()
        {
            //return applications.Where(e => e.Role == Roles.JobProvider).ToList();
            return applications;
        }
    }
}
