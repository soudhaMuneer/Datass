// See https://aka.ms/new-console-template for more information
using Workshop.Manager;

namespace Workshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Admin landing = new Admin();
           

            while (true)
            {
                Console.WriteLine("Welcome to the job portal admin module!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string? input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter Name");
                        string? name= Console.ReadLine();
                        Console.WriteLine("Enter Email");
                        string? mail = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string? pass = Console.ReadLine();
                        landing.Register(name, mail, pass);
                        Console.WriteLine("Registered Successfuly !!");


                        break;
                        case "2":
                        Console.WriteLine("Enter Email");
                        string? mail1 = Console.ReadLine();
                        Console.WriteLine("Enter Password");
                        string? pass1 = Console.ReadLine();
                        landing.Login(mail1, pass1);
                        break;
                        case "3":
                        Console.WriteLine("See You Later ");
                        return;
                        default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            }
        }
}