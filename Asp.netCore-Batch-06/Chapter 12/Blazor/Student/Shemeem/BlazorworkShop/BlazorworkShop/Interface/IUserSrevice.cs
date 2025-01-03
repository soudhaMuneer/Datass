using System;
using BlazorworkShop.Models;

namespace BlazorworkShop.Interface
{
	public interface IUserService
	{
        User login(string email, string password);

        User register(User user);

        void Logout();
    }
}

