﻿using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Exceptions;
using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;

namespace HireMeNow_BlazorApp.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User> { new User( "jobprovider", "", "jobprovider@gmail.com", 123, "123", Roles.JobProvider,new Guid("2c8303fb-c1e1-4fa6-a2e1-272472b4beb5"),new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6")),
            new User( "Yadhu", "", "yadhu.aitrich@gmail.com", 9633508643, "123", Roles.JobSeeker,null,new Guid("1d8303fb-c1e1-4fa6-a2e1-272472b2beb4")),
         new User( "Soudha", "", "soudha.aitrich@gmail.com", 9878956521, "123", Roles.CompanyMember,new Guid("1d8303fb-c1e1-4fa6-a2e1-272472b2beb4")),
            new User( "admin", "", "admin@gmail.com", 0487321312, "123", Roles.Admin)};
        User loggedUser;
        public User getById(Guid userId)
        {
           User user= users.Where(e=>e.Id==userId).FirstOrDefault();
            return user;
        }

        public User Login(string email, string password)
        {
            loggedUser = users.Where(e=>e.Email==email && e.Password==password).FirstOrDefault();
            return loggedUser;
        }

        public User register(User user)
        {
            user.Id = Guid.NewGuid();
            user.Role = Roles.JobSeeker;

            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return user;
            }
            else
            {
                throw new UserAlreadyExistException(user.Email);
            }
        }

        public User Update(User updatedUser)
        {
            int indexToUpdate = users.FindIndex(item => item.Id == updatedUser.Id);
            if (indexToUpdate != -1)
            {
                // Modify the properties of the item at the found index
                users[indexToUpdate].About = updatedUser.About ?? users[indexToUpdate].About;
                users[indexToUpdate].Experiences = updatedUser.Experiences ?? users[indexToUpdate].Experiences;
                users[indexToUpdate].Educations = updatedUser.Educations ?? users[indexToUpdate].Educations;
                users[indexToUpdate].Skills = updatedUser.Skills ?? users[indexToUpdate].Skills;
                users[indexToUpdate].FirstName = updatedUser.FirstName??users[indexToUpdate].FirstName;
                users[indexToUpdate].LastName = updatedUser.LastName??users[indexToUpdate].LastName;
                users[indexToUpdate].Location = updatedUser.Location??users[indexToUpdate].Location;
                users[indexToUpdate].Gender = updatedUser.Gender??users[indexToUpdate].Gender;
                users[indexToUpdate].Phone = updatedUser.Phone==null?users[indexToUpdate].Phone : updatedUser.Phone;
                users[indexToUpdate].Image = updatedUser.Image??users[indexToUpdate].Image;
            }
            else
            {
                throw new NotFoundException("User Not Found");
            }

            return users[indexToUpdate];
        }

        public User memberRegister(User user)
        {
            user.Id = Guid.NewGuid();
            user.Role = Roles.CompanyMember;

            if (users.Find(e => e.Email == user.Email) == null)
            {
                users.Add(user);
                return user;
            }
            else
            {
                throw new UserAlreadyExistException(user.Email);
            }
        }

        public List<User> memberListing(Guid companyId) 
        {
            var memberList = users.Where(e=>e.Role==Roles.CompanyMember&& e.companyId==companyId).ToList();
            return memberList;
        }
		public List<User> jobseekerListing()
		{
			var memberList = users.Where(e => e.Role == Roles.JobSeeker).ToList();
			return memberList;
		}
        public List<User> jobProviderListing()
        {
            var memberList = users.Where(e => e.Role == Roles.JobProvider).ToList();
            return memberList;
        }

        public User getuser()
		{
			return loggedUser;
		}
	

		public List<User> getAllUsers()
		{
            return users;
		}

        public void memberDeleteById(Guid id)
        {
            User user = users.Find(e => e.Id==id);
            if (user!=null)
            {
                users.Remove(user);
            }
        }

		public void Logout()
		{
			//loggedUser=new User();
            loggedUser=null;
		}
	}

    

}
