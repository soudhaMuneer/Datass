﻿using Admin_Job.Interface;
using Admin_Job.Manager;

namespace Admin_Job
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}
