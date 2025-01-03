using System;
using System.Transactions;

namespace MyApp
{
    internal class Find
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            //first row
            Console.WriteLine(a+"" +a+""+a+""+a+"");


            //second row
            Console.WriteLine(a);

            //third row
            Console.WriteLine("{0} {0} {0} {0}", a);
            //fourth row
           Console.WriteLine("{0}{0}{0}{0}",a);
        }

    }
}
   
    