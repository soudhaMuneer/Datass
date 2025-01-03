// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            data.Add (1);
            data.Add(2);
            data.Add(3);
            data.Add("one");
            Console.WriteLine("Number Array:");
            foreach (var i in data)
            {
                Console.WriteLine(i);
            }
        }
    }
}