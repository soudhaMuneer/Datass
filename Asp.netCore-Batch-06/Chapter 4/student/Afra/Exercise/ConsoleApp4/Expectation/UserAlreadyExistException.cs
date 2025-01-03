using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Expectation
{
    [Serializable]
    internal class UserAlreadyExistException:Exception
    {
        public UserAlreadyExistException() { }
        public UserAlreadyExistException(string email) 
            : base(string.Format("User already exist with this email",email)) { }
    }
}
