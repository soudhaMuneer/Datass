using JobSeeker.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSeeker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public long Phone { get; set; }
        [Required]
        public string Password { get; set; }
        public Roles Role { get; set; }
        public string ConfirmPassword { get; set; }
        public string Gender { get; set; }
        public User() { }
        public User(int id, string firstname, string lastname, string email, long phone, string password, Roles roles)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Password = password;
            Role = roles;
        }
    }
}
