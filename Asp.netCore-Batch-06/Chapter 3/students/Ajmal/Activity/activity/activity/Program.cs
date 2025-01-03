// See https://aka.ms/new-console-template for more information
using activity;

namespace Activity
{
    public class Program
    {
        static void Main(string[] args)
        {
            Test1 test = new Test1();
            Console.WriteLine("Enter UserName");
            string inp = Console.ReadLine();
            test.User = inp;
            Console.WriteLine("Enter UserMail");
            string inp1 = Console.ReadLine();
            test.email = inp1;
            Console.WriteLine("Enter PhoneNumber");

            int inp2 = Convert.ToInt32(Console.ReadLine());
            
            test.phone = inp2;
            Console.WriteLine("Enter Name");
            string inp3 = Console.ReadLine();
            
            test.name = inp3;
            Console.WriteLine("Enter Password");
            int inp4 = Convert.ToInt32(Console.ReadLine());
            test.Password = inp4;
            Console.WriteLine();
            test.Login("hai",123);
            Console.WriteLine();
            test.Welcome();
            Console.WriteLine();
            test.Home();

        }
    }
}
