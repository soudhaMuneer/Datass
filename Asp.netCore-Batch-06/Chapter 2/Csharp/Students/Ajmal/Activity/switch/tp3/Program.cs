// See https://aka.ms/new-console-template for more information

namespace tp3
{
    class programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a to g");

            string? a = Console.ReadLine();
            switch (a)
            {
                case "a":
                    
                        Console.WriteLine("sunday");
                    
                    break;
                case "b":
                   
                        Console.WriteLine("monday");
                    break;
                case "c":

                    Console.WriteLine("tuesday");
                    break;
                case "d":
                    Console.WriteLine("wednesday");
                    
                    break;
                case "e":
                    Console.WriteLine("thursday");

                    break;
                case "f":

                    Console.WriteLine("friday");
                    break;
                case "g":

                    Console.WriteLine("saturday");
                    break;


            }
        }
    }
}
