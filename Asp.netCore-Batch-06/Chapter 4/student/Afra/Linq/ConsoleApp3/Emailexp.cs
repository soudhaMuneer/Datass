using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Emailexp:Exception
    {
        public Emailexp() { }
        public Emailexp(string message) : base(string.Format(message + " incorrect email"))
        { }
    }
}
