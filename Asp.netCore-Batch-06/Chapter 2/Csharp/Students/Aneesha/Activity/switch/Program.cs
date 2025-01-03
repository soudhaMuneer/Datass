namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a % 2)
            {
                case 0:
                    Console.WriteLine("Number is Even");
                break;

                case 1:
                    Console.WriteLine("Number is Odd");
                break;

            }



        }

    }
}