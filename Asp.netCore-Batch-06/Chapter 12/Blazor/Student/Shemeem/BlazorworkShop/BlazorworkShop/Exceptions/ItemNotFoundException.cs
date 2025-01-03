﻿using System;
namespace BlazorworkShop.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {

        }
        public NotFoundException(string message)
        : base(message)
        {
        }
    }
}

