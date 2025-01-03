using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkShop1.Models;

namespace WorkShop1.Interface
{
    public interface IUserRepository
    {
        List<User> getAll();
    }
}
