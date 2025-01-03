namespace MyApp
{
    internal class FindApp
    {
        static void Main(string[] args) 
        
        {
            Console.WriteLine("Enter The 1st Number Here And Click Enter Key.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The 2nd Number Here And Click Enter Key.");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number Here And Click Enter Key.");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x >= y && x >= z)
            {
                Console.WriteLine("1st One Is The Greatest Number.");
            }
            else if(y >= z && y >= x)
            {
                Console.WriteLine("2nd One Is The Greatest Number.");

            }
            else
            {
                Console.WriteLine("3rd One Is The Greatest Number.");
            }
        }
    }
}