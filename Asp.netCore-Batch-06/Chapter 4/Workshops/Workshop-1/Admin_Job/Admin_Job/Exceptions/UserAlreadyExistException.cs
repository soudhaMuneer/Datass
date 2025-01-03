﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Job.Exceptions
{
    [Serializable]
    public class UserAlreadyExistException:Exception
    {
        public UserAlreadyExistException()
        {

        }
        public UserAlreadyExistException(string email)
             : base(String.Format("User Already Exist with this email ", email))
        {

        }
    }
}
