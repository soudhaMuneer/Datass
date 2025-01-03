using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Register.Interfaces
{
	public interface IPublicRepository
	{
		Task<bool> IsUserExist(string  phone);
		Task<bool> userRegister(Models.User user);
	}
}
