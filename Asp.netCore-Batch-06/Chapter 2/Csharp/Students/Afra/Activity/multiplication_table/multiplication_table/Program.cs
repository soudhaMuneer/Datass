using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            do
            {
                int m = a * i;
                Console.WriteLine("{0} * {1}= {2}", a, i, m);
                i++;
            } while (i <= 10);


            Console.WriteLine("do you want to continue?yes/no");
            string result = Console.ReadLine();
            do
            {
                Console.WriteLine("enter a number");
                int b = Convert.ToInt32(Console.ReadLine());
                int j = 1;

                while (j <= 10)
                {
                    int m = b * j;
                    Console.WriteLine("{0} * {1}= {2}", b, j, m);
                    j++;
                }
                result = "no";
            } while (result == "yes");

            Console.Read();
        }
    }
}
