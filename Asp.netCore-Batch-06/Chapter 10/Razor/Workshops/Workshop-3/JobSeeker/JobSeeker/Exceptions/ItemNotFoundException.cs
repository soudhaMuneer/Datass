﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.Exceptions
{
    [Serializable]
    public class ItemNotFoundException: Exception
    {
        public ItemNotFoundException()
        {
            
        }
        public ItemNotFoundException(string message)
        : base(message)
        {
        }
    }
}
