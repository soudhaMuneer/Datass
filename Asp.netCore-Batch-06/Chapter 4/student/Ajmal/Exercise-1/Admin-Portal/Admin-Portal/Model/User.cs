﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Portal.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lname {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id,string name,string lname,string email,string pass)
        {
            Id = id;
            Name = name;
            Lname = lname;
            Email = email;
            Password = pass;
        }
       
        public User() { }

    }
}
