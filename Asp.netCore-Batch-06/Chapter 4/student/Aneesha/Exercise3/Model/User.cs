using Exercise3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.Model
{
    public class User
    {
        internal string email;

        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string phoneNumber { get; set; }
        public Roles Role  { get; internal set; }

        public User(int id, string name, string companyname, string email, string password, string phoneNumber,Roles Role)
        {
            Id = id;
            Name = name;
            CompanyName = companyname;
            Email = email;
            Password = password;
            Roles roles = Role;
            phoneNumber = phoneNumber;
        }

        public User()
        {
        }
    }
}
