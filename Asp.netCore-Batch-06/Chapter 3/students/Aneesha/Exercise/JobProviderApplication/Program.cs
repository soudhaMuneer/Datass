using JobProviderApplication.Interface;
using JobProviderApplication.Manager;
namespace JobProviderApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            JobProvider_Manager manager = new JobProvider_Manager();

            while (true)
            {
                Console.WriteLine("Job Provider Application");
                Console.WriteLine("1. Post Job");
                Console.WriteLine("2. Get Jobs");
                Console.WriteLine("3. Add Application");
                Console.WriteLine("4. Get Applications");
                Console.WriteLine("5. Schedule Interview");
                Console.WriteLine("6. Get Interviews");
                Console.WriteLine("7. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.PostJob();
                        break;
                    case 2:
                        manager.GetJob();
                        break;
                    case 3:
                        manager.AddApplication();
                        break;
                    case 4:
                        manager.GetApplication();
                        break;
                    case 5:
                        manager.ScheduleInterview();
                        break;
                    case 6:
                        manager.GetInterview();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
