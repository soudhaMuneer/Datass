using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.application
{
    public class InavalidUserException:Exception
    {
        public InavalidUserException() 
        {

        }
        public InavalidUserException(string message)
            : base(String.Format(message + " is Already existed"))
        {
           
        }
        public InavalidUserException(int message)
            : base(String.Format(message + " is Already existed"))
        {

        }
    }
}
