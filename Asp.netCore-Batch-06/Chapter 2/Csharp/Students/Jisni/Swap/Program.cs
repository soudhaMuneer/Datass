// See https://aka.ms/new-console-template for more information
namespace Swap
{
    class Swap
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Input the First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("\nAfterSwapping :");
            Console.WriteLine("\n First Number:"+ num1);
            Console.WriteLine("\n Second Number:"+ num2);




        }
    }
}


