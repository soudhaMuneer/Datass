
using JobSeeker.Enums;
using JobSeeker.Exceptions;
using JobSeeker.Interfaces;
using JobSeeker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.Repositories
{
    public sealed class UserRepository : IUserRepository
    {
        UserRepository()
        {

        }
        private static UserRepository instance = null;
        private static readonly object padlock = new object();
        private static User loggedUser=new User();

        private List<User> users = new List<User> { new User(1, "jobprovider", "", "jobprovider@gmail.com", 123, "123", Roles.JobProvider) };
        private int nextId = 2;
        public static UserRepository Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new UserRepository();
                    }
                    return instance;
                }
            }
        }

        public List<User> getAll()
        {
            return users.Where(e => e.Role == Roles.JobSeeker).ToList();
        }


        public bool register(User user)
        {
            user.Id = users.Count + 1;
            user.Role = Roles.JobSeeker;
           // nextId++;
            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistException(user.Email);
        }

        public User login(string email, string password)
        {
            loggedUser= users.FirstOrDefault(e => e.Email == email && e.Password == password,new User());
            return loggedUser;
        }
        public User getLoggedUser()
        {
            return loggedUser;
        }

        internal void logout()
        {
            loggedUser=new User();
        }

        internal User getById(int uid)
        {
            return users.FirstOrDefault(e => e.Id == uid , new User());
          
        }
    }
}
