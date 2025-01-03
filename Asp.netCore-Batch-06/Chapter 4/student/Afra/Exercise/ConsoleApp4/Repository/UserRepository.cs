using ConsoleApp4.Interface;
using ConsoleApp4.Models;
using ConsoleApp4.Enums;
using ConsoleApp4.Expectation;
using ConsoleApp4.Expectation;
using ConsoleApp4.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Repository
{
    public sealed class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        { new User(1,"admin1","admin1","admin1@gmail.com","123",1234567890,Roles.Admin),
          new User(2,"admin2","admin2","admin2@gmail.com","123",1234567890,Roles.Admin),
          new User(3,"admin3","admin3","admin3@gmail.com","123",1234567890,Roles.Admin),
        };
        private static User loggedUser = new User();
        private int nextId = 2;
        public List<User> getAll()
        { 
            return users.Where(e => e.roles==Roles.Admin).ToList();
        }
        public User login(string email, string password)
        {
            return users.FirstOrDefault(e => e.Email==email && e.Password==password);
        }
        public User getLoggedUser()
        {
            return loggedUser;
        }
    }
}
