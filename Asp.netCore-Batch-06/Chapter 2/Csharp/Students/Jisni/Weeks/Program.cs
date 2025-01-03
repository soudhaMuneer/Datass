// See https://aka.ms/new-console-template for more information
namespace Weeks
{
    class Weeks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string numbers = Console.ReadLine();
            switch (numbers)
            {
                case "1":
                    Console.WriteLine("Sunday");
                    break;
                case "2":
                    Console.WriteLine("Monday");
                    break;
                case "3":
                    Console.WriteLine("Tuesday");
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
                    Console.WriteLine("press any key to exit");
            }
        }
    }
}

