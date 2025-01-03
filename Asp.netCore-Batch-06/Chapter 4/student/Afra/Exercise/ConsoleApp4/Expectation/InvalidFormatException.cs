using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Expectation
{
    [Serializable]
    internal class InvalidFormatException:Exception
    {
        public InvalidFormatException() { }
        public InvalidFormatException(string message) : base(message) { }

    }
}
