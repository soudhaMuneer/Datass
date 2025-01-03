using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit, i, j;
            Console.WriteLine("enter the limit");
            limit = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= limit; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
