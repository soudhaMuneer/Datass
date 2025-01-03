namespace workshop
{
    public class workshop
    {
        struct Jobprovider
        {
            public string CompanyName;
            public string Email;
            public string Password;
        }
        static Jobprovider[] jobprovider = new Jobprovider[3];
        static Jobprovider loggedinuser;
        static int userCount = 0;

        static void Main(string[] args)
        {
            string ch;
            do
            {
                Console.WriteLine("Choose option ");
                Console.WriteLine("1 .Loggin");
                Console.WriteLine("2 .Register New Provider");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Login();
                        break;

                    case "2":
                        Register();
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;


                }

                Console.WriteLine("Do you Want to Continue Y/N");
                ch=Console.ReadLine();
            } while (ch == "Y" || ch == "y");

        }


        static void Login()
        {
            Console.WriteLine("Enter your Email");
            string Email=  Console.ReadLine();

            Console.WriteLine("Enter your Password");
            string Password=  Console.ReadLine();


            foreach(Jobprovider job in jobprovider)
            {
                if (job.Email == Email && job.Password == Password)
                {
                    loggedinuser = job;
                    Console.WriteLine("Loggin Success");
                    Console.WriteLine("Display CompanyNAme {0}", loggedinuser.CompanyName);

                }
            }

            

        }
        static void Register()

        {
            Jobprovider jobProvider = new Jobprovider();

            Console.WriteLine("Enter your CompanyName");
            jobProvider.CompanyName =  Console.ReadLine();

            Console.WriteLine("Enter your Email");
            jobProvider.Email = Console.ReadLine();

            Console.WriteLine("Enter your Password");
            jobProvider. Password = Console.ReadLine();

            jobprovider[userCount] = jobProvider;
            userCount++;

        }

        
    }
}