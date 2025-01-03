using System.Net.NetworkInformation;

namespace swap
{
    class Swap
    {
     public static void Main(string[] args)
        {
            //int a, b, temp;

            //Console.WriteLine("Enter the First number ");
            // a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            // b = Convert.ToInt32(Console.ReadLine());

            //temp = a;
            //a = b;
            //b = temp;

            //Console.Write("\nAfter swaping");
            //Console.WriteLine("\n First number :" +a);
            //Console.WriteLine("\n Second number :" + b);

            //Console.Read();

            int a = 10;
            int b = 20;
            int temp;

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);   

        }
    }
}