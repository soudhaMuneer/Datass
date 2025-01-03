using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverted_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the limit");
            int limit=Convert.ToInt32(Console.ReadLine());
            for (int i = limit; i >= 1; i--)
            {
                for (int spaces = 0; spaces < limit - i; spaces++)
                {
                    Console.Write(" ");
                }
                for ( int stars = 1; stars <= 2 * i - 1; stars++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine(); 
        }
    }
}
