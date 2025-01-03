using Admin_Portal.Interface;
using Admin_Portal.Services;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Jobportal();
            menu.Menu();
        }
    }
}