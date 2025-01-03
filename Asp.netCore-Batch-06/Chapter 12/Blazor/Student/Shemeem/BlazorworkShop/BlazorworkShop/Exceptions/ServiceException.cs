using System;
namespace BlazorworkShop.Exceptions
{
    [Serializable]
    public class ServiceException : Exception
    {
        public ServiceException()
        {

        }
        public ServiceException(string message) : base(message)
        {

        }
    }
}

