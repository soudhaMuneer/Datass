using System.ComponentModel;
using System.Transactions;

namespace MyApp
{
    internal class Find
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers to find its average here");
            Console.WriteLine("enter first number:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number:");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number:");
            int c=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter fourth number:");
            int d=Convert.ToInt32(Console.ReadLine());
          int Add=a+b+c+d;
            int avg = Add / 4;
            Console.WriteLine("average =" + avg);

        }
    }
}
