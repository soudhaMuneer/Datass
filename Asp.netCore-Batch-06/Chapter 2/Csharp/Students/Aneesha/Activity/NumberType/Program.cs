namespace NumberType
{
    class NumberType
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(a <= 0)
            {
                Console.WriteLine("Number is Negative");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}