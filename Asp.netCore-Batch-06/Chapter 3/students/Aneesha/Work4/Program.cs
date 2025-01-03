using Work4.Interface;
using JobProvider.Model;

namespace Work4
{
     internal class Work4
    {
        static void Main(string[] args)
        {
            JobRepo iJob = new Manager.JobProvider_Manager();
            Console.WriteLine("Welcome to the job provider module!");

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        iJob.Register();
                        break;
                    case "2":
                        iJob.Login();
                        break;

                    case "3":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
