using System.Transactions;

namespace myApp
{
    internal class Find
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
                int a=Convert.ToInt32(Console.ReadLine());
            int i = 0; 
            while (i < a)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}