// See https://aka.ms/new-console-template for more information
using System;

namespace OddorEven

{
    class OddorEven {
        static void Main(string[] args)
        {

            Console.Write("Enter any number to check even or odd: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number % 2)
            {
                case 0:
                    Console.WriteLine(number + " is even number");
                    break;
                case 1:

                    Console.WriteLine(number + " is  odd number");
                    break;
            }
        }
}
}
