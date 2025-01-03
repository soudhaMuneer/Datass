using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace Exercise3.Exceptions
    {
        public class InvalidFormatException : System.Exception
        {
            public InvalidFormatException(string Message) : base(Message)
            {
            }
        }
    }


