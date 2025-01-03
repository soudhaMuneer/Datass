namespace Multiplication
{
    class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(a+"*"+i+"="+i*a);
            }


         }
    }
}
