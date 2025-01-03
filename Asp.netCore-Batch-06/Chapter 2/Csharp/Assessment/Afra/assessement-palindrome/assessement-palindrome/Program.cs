using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessement_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0, num;
            Console.WriteLine("enter a number");
            a=Convert.ToInt32(Console.ReadLine());
            num = a;
            while (a > 0)
            {
                b = a % 10;
                sum=(sum*10) + b;
                a = a / 10;
            }
            if (sum == num)
            {
                Console.WriteLine("number is palindrome");
            }
            else
            {
                Console.WriteLine("number is not palindrome");
            }
          Console.ReadLine();
        }
    }
}
