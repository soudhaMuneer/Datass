using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter limit");
            int limit = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= limit; ++i)
            {
                for (int j = 1; j <= i; ++j)
                {
                    Console.Write(" {0} ",j);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
