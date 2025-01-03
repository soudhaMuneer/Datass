using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionActivity
{
    public  class JobSeeker
    {
        public int Id;
        public string Name;
        public string Email;
        public string Phone;
        public string City;
    }


    public class InvalidEmailFormatException : Exception
    {
        public InvalidEmailFormatException(string Email) : base($"Invalid email format : {Email}")
        {
            Email = Email;
        }

        public string Email { get; }
    }

    public class InvalidPhoneNumberLengthException : Exception
    {
        public InvalidPhoneNumberLengthException(string PhoneNumber) : base($"Invalid Phone number lenght : {PhoneNumber}")
        {
            PhoneNumber = PhoneNumber;
        }
        public string PhoneNumber { get; }
    }

    public class Validator
    {
        public static void ValidateEmail(string Email)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[\w\.-]+@[\w\.-]+$"))
            {
                throw new InvalidEmailFormatException(Email);
            }
        }
        public static void ValidatePhoneNumber(string PhoneNumber)
        {
            if (PhoneNumber.Length != 10)
            {
                throw new InvalidPhoneNumberLengthException(PhoneNumber);
            }


        }
    }
}
