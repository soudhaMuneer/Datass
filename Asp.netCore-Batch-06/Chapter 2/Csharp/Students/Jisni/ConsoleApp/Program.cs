// See https://aka.ms/new-console-template for more information
namespace app
{

    internal class ConsoleApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  1st Number");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  3rd Number");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && b >= c)
            {
                Console.WriteLine("ConsoleApp is a");
            }
            else if (b>=a && b>=c)
            {
                Console.WriteLine("ConsoleApp is b");
            }
            else
            {
                Console.WriteLine("ConsoleApp is c");
            }
        }
    }
}
