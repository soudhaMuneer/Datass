// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /* The code below will print the words Hello World
            to the screen, and it is amazing */
            Console.WriteLine("Hello World!");
            MyMethod();
            


        }

        static void MyMethod()
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("the given number is even");
            }
            else
            {
                Console.WriteLine("the given number is odd");
            }
            method2();

        }
        static void method2()
        {
            MyMethod();

        }
    }
}