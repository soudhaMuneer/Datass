using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //non abstract method
        public bool login(string username, string password)
        {
            Console.WriteLine("login success!!!");
            return true;
        }
        abstract public void welcome();
    }
}
