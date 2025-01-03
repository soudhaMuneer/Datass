using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
