using System;
using BlazorworkShop.Models;

namespace BlazorworkShop.Interface
{
	public interface IPublicService
	{
		public User LoginJobSeeker(string email, string password);
		public User Register(User NewUser);
	}
}

