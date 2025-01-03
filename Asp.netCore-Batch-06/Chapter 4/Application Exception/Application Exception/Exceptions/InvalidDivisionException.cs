using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Exception.Exceptions
{
    public class InvalidDivisionException : Exception
    {
        public InvalidDivisionException()
        {
        }
        public InvalidDivisionException(int num)
        : base(String.Format("Invalid Number: {0}", num))
        {

        }
    }
}
