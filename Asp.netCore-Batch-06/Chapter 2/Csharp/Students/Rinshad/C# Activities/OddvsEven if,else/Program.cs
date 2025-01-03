namespace MyApp{
    internal class OddVsEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number below and press Enter key");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("Entered number is Even");
            }
            else {
                Console.WriteLine("Entered number is Odd");
                    }
        }
    }
}