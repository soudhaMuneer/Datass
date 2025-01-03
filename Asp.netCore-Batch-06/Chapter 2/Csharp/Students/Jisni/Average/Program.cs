// See https://aka.ms/new-console-template for more information
namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First Number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Third Number:");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Four Number:");
            double num4 = Convert.ToDouble(Console.ReadLine());

                double average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The Average of {0},{1},{2},{3} is:", num1, num2, num3, num4, average);



        }
    }
}