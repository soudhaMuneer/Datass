using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to define row");
            int print = Convert.ToInt32(Console.ReadLine());
            for (int i = print; i >0; i--)
            {
                for (int j = 0; j < print - i; j++)
                {
                    if (j == 0 || j == (print-i-1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            for (int i = 0; i < print; i++)
            {
                Console.Write("*");
            }
        }
    }
}