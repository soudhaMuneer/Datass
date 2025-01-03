// See https://aka.ms/new-console-template for more information
using Exercise.Manager;
using Exercise.Model;

namespace Exercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            JobSeekerManager menu = new JobSeekerManager();

            
            while ( true) 
            {
                Console.WriteLine("1.Register\n");
                Console.WriteLine("2.Login\n");
                Console.WriteLine("3.Exit\n");
                string inp = Console.ReadLine();

                switch (inp)
                {
                    case "1":
                        Console.WriteLine("----------------------------------------------------------Registration Form----------------------------------------------------------");
                        Console.Write("Enter Your FirstName :- ");
                        string FirstName = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter Your LastName :- ");
                        string ln = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter Your Email :- ");
                        string mail = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter Your Phone Number :- ");
                        string phone = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter Your Place :- ");
                        string location = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter About You :- ");
                        string aboutme = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Enter Your Qualification :- ");
                        string Qualification = Console.ReadLine();
                        Console.WriteLine();
                       
                        Console.Write("Enter Your Password :- ");
                        string pass = Console.ReadLine();
                        Console.WriteLine();
                        menu.Register(FirstName, ln, mail, phone, location, aboutme, Qualification, pass);
                        Console.WriteLine("Registered Successful");
                        Console.WriteLine();

                        
                        break;
                        case "2":
                        Console.WriteLine("----------------------------------------------------------Login Form----------------------------------------------------------");

                        Console.Write("Enter Your Email :- ");
                        string mail1 = Console.ReadLine();
                        Console.Write("Enter Your Password :- ");
                        string pass1 = Console.ReadLine();
                        menu.LoggedIn(mail1, pass1);
                        break;
                        case "3":
                        Console.WriteLine("You were Exited From this Application");
                        return;
                        break;
                }
            }
        }
    }
}
