// See https://aka.ms/new-console-template for more information
namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            for (x = 5; x >= 1; x--)
            {
                for (y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}