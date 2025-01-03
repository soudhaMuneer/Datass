namespace Mutiply
{
    class Mutiply
    {
        static void Main(string[] args)


        {

            Console.WriteLine("Enter 1st number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int b = Convert.ToInt32(Console.ReadLine());

            int Result = a * b;

            Console.WriteLine("Output is : "+ Result);
        }
    }
}