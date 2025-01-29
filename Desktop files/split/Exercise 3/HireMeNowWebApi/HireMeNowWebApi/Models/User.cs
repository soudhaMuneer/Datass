﻿using HireMeNowWebApi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMeNowWebApi.Models
{
    public class User:ProfileDetails
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Gender { get; set; }
        public string? Location { get; set; }
        public long Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public Roles Role { get; set; }
        public User() { }
        public User( string firstname, string lastname, string email, long phone, string password, Roles roles,Guid? companyid=null, Guid? id = null)
        {
            Id = id?? Guid.NewGuid();
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Password = password;
            Role = roles;
            companyId=companyid;
        }
    }
}
