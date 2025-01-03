namespace Week
{
    class Week
    {
        static void Main(string[] args)

        {
            int choose;
            Console.WriteLine("Enter number between 1 to 7");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    Console.WriteLine("Monday");
                break;

                    case 1:
                    Console.WriteLine("Tuesday");
                    break;

                    case 2:
                    Console.WriteLine("Wednesday");
                    break;

                    case 3:
                    Console.WriteLine("Thursday");
                    break;

                    case 4:
                    Console.WriteLine("friday");
                    break;

                    case 5:
                    Console.WriteLine("saturday");
                    break;

                    case 6:
                    Console.WriteLine("sunday");
                    break;
            }
        }
    }
}
