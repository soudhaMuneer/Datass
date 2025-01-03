﻿using JobPortalApplication.Interfaces;
using JobPortalApplication.Models;

namespace JobPortalApplication.Services
{
    public class UserService : IUserService
    {
        public IUserRepository userRepository;
        public UserService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        public User getById(Guid userId)
        {
            return userRepository.getById(userId);
        }
		public List<User> getAllUsers()
		{
			return userRepository.getAllUsers();
		}

		public User login(string email, string password)
        {
          return userRepository.Login(email,password);
        }

        public User register(User user)
        {
            return userRepository.register(user);
        }
        
        public User registerMember(User user)
        {
            return userRepository.memberRegister(user);
        }

        public User Update(User user)
        {
            var updateduser=userRepository.Update(user);
            return updateduser;
        }

        public List<User> memberListing(Guid id)
        {
            return userRepository.memberListing(id);
        }

        //public List<User> memberListing(Guid companyId)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
