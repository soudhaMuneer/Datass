﻿using ConsoleApp4.Interface;
using ConsoleApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Manager
{
    public class UserManager:IMenu
    {
        private User loggedUser;
        public UserManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public UserManager() { }
        public void DisplayMenu()
        {
            throw new NotImplementedException();
        }
    }
}
