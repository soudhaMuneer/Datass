using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Exceptions
{
    public class UserAlreadyExistException:FormatException
    {
        public UserAlreadyExistException() { }
        public UserAlreadyExistException(string email)
            : base(String.Format("User Already Exist with email", email))
        {
            
        }

        
    }
}
