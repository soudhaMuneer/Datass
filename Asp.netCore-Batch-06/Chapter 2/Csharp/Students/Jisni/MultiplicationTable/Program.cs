// See https://aka.ms/new-console-template for more information
namespace MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int x, result;
            Console.WriteLine("Enter the Number");
            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                result = x * i;
                Console.WriteLine("{0}*{1}={2}", x, i, result);
            }

        }
    }  
}