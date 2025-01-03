using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter fourth number");
            int d = Convert.ToInt32(Console.ReadLine());

            int avg=(a+b+c+d)/4;
            Console.WriteLine("average of {0}, {1}, {2}, {3} is {4}", a, b, c, d, avg);
            Console.ReadLine();



        }
    }
}
