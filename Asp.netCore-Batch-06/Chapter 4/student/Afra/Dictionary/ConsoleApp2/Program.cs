// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> day=new Dictionary<int,string>();
            day.Add(1, "sunday");
            day.Add(2, "monday");
            day.Add(3, "tuesday");
            day.Add(4, "wednesday");
            day.Add(5, "thursday");
            day.Add(6, "friday");
            day.Add(7, "saturday");
          
            foreach(var key in day)
            {
                Console.WriteLine(key);
            }
        }
    }
}
