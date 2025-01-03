using Domain.Models;
using Domain.Enums;
using Domain.Service.Register.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;


namespace Domain.Service.Register
{
	public class PublicRepository:IPublicRepository
	{
		protected readonly EmpetzContext empetzContext;

		public PublicRepository(EmpetzContext _empetzContext)
		{
			empetzContext = _empetzContext;
		}
		public async Task<bool> userRegister(Models.User user)
		{
			user.Role = Role.PublicUser;
			user.Accountcreated = DateTime.Now;
			await empetzContext.Users.AddAsync(user);
			empetzContext.SaveChanges();
			return true;

		}
		public async Task<bool> IsUserExist(string phone)
		{
			var exist =		await empetzContext.Users.Where(e=>e.Phone==phone).FirstOrDefaultAsync();
			if(exist != null) {
				return true;
			}
			else
			{
				return false;
			}
		

		}

	}
}
