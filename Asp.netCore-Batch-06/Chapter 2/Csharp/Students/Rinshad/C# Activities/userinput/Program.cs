using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type 2nd number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type 3rd number:");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a >= b && a>= c ) { Console.WriteLine("1st is the greatest number in which you enter"); }
else if(b>=a && b>=c){ Console.WriteLine("2nd is the greatest number in which you enter"); }
            else { Console.WriteLine("3rd is the greatest number in which you enter"); }

        }
    }
}
