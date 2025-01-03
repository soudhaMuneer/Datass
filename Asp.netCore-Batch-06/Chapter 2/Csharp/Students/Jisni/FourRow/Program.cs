// See https://aka.ms/new-console-template for more information
namespace ForRow
{
    class Row
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("{0} {0} {0} {0}", number);
             Console.WriteLine("{0} {0} {0} {0}", number);
             Console.WriteLine("{0} {0} {0} {0}", number);
             Console.WriteLine("{0} {0} {0} {0}", number);
        }
    }
}
