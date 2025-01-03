
using Mvc_HireMeNow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_HireMeNow.Interfaces
{
    public interface IUserRepository
    {
      
        User register(User user);
        public User getLoggedUser();
        public User login(string email, string password);
        public User getById(Guid userId);




       
		
    }
}
