// See https://aka.ms/new-console-template for more information

using System.Transactions;

namespace Largest
{
    internal class Largest
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 3rd number");
            int c = Convert.ToInt32(Console.ReadLine());


            if (a>=b && a>=c)
            {
                Console.WriteLine("Largest is  a");
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine("Largest is b");
            }
            else
            {
                Console.WriteLine("Largest is c");
            }

        }
    }
}