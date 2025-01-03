using System.Transactions;

namespace MyApp
{
    internal class Find
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number to show its multiplication table");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int b = a * i;
                Console.WriteLine(a+"X"+i+"="+b);
            }

        }
    }
}