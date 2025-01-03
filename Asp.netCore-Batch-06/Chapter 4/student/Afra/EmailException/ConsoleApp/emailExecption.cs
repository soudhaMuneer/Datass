using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class emailExecption:Exception
    {
        public emailExecption() { }

        public emailExecption(string? message) : base(string.Format(message + "  incorrect email"))
        {
        }

        
    }
}
