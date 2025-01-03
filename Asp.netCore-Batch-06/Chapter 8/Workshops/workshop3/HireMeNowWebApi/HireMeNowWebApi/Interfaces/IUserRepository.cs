﻿using HireMeNowWebApi.Models;

namespace HireMeNowWebApi.Interfaces
{
    public interface IUserRepository
    {
        User getById(Guid userId);
        User Login(string email, string password);
        User register(User user);
		

  

    }
}
