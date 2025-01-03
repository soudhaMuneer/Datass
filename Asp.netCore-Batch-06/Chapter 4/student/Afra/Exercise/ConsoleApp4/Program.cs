// See https://aka.ms/new-console-template for more information
using ConsoleApp4.Interface;
using ConsoleApp4.Manager;
using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
           
        }
    }
}
