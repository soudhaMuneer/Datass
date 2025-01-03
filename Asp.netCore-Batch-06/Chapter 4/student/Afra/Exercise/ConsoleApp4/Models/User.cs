using ConsoleApp4.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone {  get; set; }
        public Roles  roles { get; set; }  
        public User() { }
        public User(int id, string firstName, string lastName, string email, string password, int phone, Roles roles)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Phone = phone;
            this.roles = roles;
        }
    }
}
