using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, num, sum = 0;
            Console.WriteLine("enter a number");
            a=Convert.ToInt32(Console.ReadLine());
            num = a;
            while (a > 0)
            {
                b = a % 10;
                sum = sum + (b * b * b);
                a=a / 10;
            }
            if (num == sum)
            {
                Console.WriteLine("palindrome number");
            }
            else
            {
                Console.WriteLine("not palindrome number");
            }
            Console.ReadLine();
        }
    }
}
