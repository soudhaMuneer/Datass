using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Models;
using ConsoleApp4.Repository;


namespace ConsoleApp4.Interface
{
    internal interface IUserRepository
    {
        List<User> getAll();
    }
}
