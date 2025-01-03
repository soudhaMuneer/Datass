using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Expect:Exception
    {
        public Expect() { }
        public Expect(string message):base(string.Format(message + " incorrect phone number"))
        { 
            
        }
    }
}
