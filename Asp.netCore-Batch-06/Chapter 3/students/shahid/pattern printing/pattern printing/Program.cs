using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = 5;
            for(int i = 0; i < step; i++)
            {
                for(int j = 0; j < step - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < (2*i-1) ;  k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}