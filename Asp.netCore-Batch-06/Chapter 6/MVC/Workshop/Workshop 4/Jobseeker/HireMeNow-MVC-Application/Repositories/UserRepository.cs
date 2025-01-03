using HireMeNow_MVC_Application.Enums;
using HireMeNow_MVC_Application.Exceptions;
using HireMeNow_MVC_Application.Interfaces;
using HireMeNow_MVC_Application.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNow_MVC_Application.Repositories
{
    public sealed class UserRepository : IUserRepository
    {
        public UserRepository()
        {

        }

        private static User loggedUser = new User();

        private List<User> users = new List<User> { new User( "jobprovider", "", "jobprovider@gmail.com", 9877896541, "123", Roles.JobProvider,new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),new Guid("ae32ba86-8e8d-4615-aa47-7387159e705d")),
         new User( "Yadhu", "", "yadhu.aitrich@gmail.com", 123, "123", Roles.JobSeeker,null,new Guid("1d8303fb-c1e1-4fa6-a2e1-272472b2beb4")),
         new User( "rs", "", "sad@gmail.com", 123, "123", Roles.CompanyMember,new Guid("1d8303fb-c1e1-4fa6-a2e1-272472b2beb4")),
            new User( "admin", "", "admin@gmail.com", 123, "123", Roles.Admin)};


      


        public bool register(User user)
        {
            user.Id = Guid.NewGuid();
            user.Role = Roles.JobSeeker;

            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return true;
            }
            throw new UserAlreadyExistException(user.Email);
        }

        public User login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(e => e.Email == email && e.Password == password, new User());
            return loggedUser;
        }
        public User getLoggedUser()
        {
            return loggedUser;
        }

        internal void logout()
        {
            loggedUser = new User();
        }

        public User getById(Guid uid)
        {
            return users.FirstOrDefault(e => e.Id == uid, new User());

        }
        public bool ApplyJob(Guid jobId, Guid userId)
        {
            loggedUser = getById(userId);

            loggedUser.AppliedJobs.Add(jobId);
           
            return true;
        }














    }
}
