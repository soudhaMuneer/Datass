using Admin_Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Interface
{
    public interface IUserRepository
    {
        bool Newuser(User user);
        List<User> Getuser();
    }
}
