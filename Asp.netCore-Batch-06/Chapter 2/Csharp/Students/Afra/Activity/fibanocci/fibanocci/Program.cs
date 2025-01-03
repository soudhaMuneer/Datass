using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibanocci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, i, num;
            Console.WriteLine("enter a number of elements");
            num=Convert.ToInt32(Console.ReadLine());
            Console.Write(num1+" "+ num2+ " ");
            for (i = 2; i < num; i++) {
                num3 = num1 + num2;
                Console.Write(num3+" ");
                num1 = num2;
                num2 = num3;
            }
            Console.ReadLine();

        }
    }
}
