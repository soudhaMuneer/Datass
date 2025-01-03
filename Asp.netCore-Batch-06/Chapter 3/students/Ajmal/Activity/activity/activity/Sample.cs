using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity
{
    public abstract class Sample
    {
        public string? User { get; set; }
        public int Password { get; set; }


        public void Login(string user, int password)
        {
            if (this.User==user && this.Password == password)
            {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
        abstract public void Welcome();
    }
}