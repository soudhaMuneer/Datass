namespace Average
{
    class Average
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first Number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first Number");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first Number");
            int d = Convert.ToInt32(Console.ReadLine());

            int result = (a + b + c + d) / 4;

            Console.WriteLine("Average of numbers is" + result);
        }
    }
}