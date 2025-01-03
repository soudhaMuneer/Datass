namespace Exercise2
{
    class Exercise2
    {
        struct Details
        {
            public string CompanyName;
            public string Email;
            public string Password;
            public string Website;
            public string ContactNumber;
            public string Location;
        }
        struct Interview
        {
            public string Title;
            public DateTime Date;
            public string Time;
            public string Location;
        }

        static Details[] providers = new Details[10];
        static int userCount = 0;
        static bool isLoggedIn = false;

        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Job Portal");
            string ch;
            do
            {
                Console.WriteLine("****************************************");
                Console.WriteLine("Choose the option :");
                Console.WriteLine(" 1. Register Company ");
                Console.WriteLine(" 2. Login to Company ");
                Console.WriteLine(" 3. Exit ");
                Console.WriteLine("****************************************");

                string? choice = Console.ReadLine();
                switch (choice)

                {
                    case "1":
                        Register();
                        break;

                    case "2":
                        Login();
                        break;

                    case "3":
                        Exit();
                        break;
                }
                Console.WriteLine("Do you Want to continue (Y/N)");
                ch = Console.ReadLine();

            }
            while (ch == "y" || ch == "Y");
        }

        static void Register()
        {
            Details provider = new Details();

            Console.WriteLine("Enter Company Name");
            provider.CompanyName = Console.ReadLine();
            Console.WriteLine("Enter Email");
            provider.Email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            provider.Password = Console.ReadLine();
            Console.WriteLine("Enter Website");
            provider.Website = Console.ReadLine();
            Console.WriteLine("Enter Phone number");
            provider.ContactNumber = Console.ReadLine();
            Console.WriteLine("Enter Location");
            provider.Location = Console.ReadLine();

            Console.WriteLine("Registration successfull");
            Console.WriteLine("Welcome to job portal ");

            providers[userCount] = provider;
            userCount++;
        }

        static void Login()
        {
            Console.WriteLine("****************************************");

            Console.WriteLine("Enter Email : ");
            string? Email = Console.ReadLine();

            Console.WriteLine("Enter password : ");
            string? Password = Console.ReadLine();

            Console.WriteLine("..........................................................");

            bool loginSuccessful = false;

            foreach (Details i in providers)
            {
                if (i.Email == Email && i.Password == Password)
                {
                    loginSuccessful = true;
                    isLoggedIn = true;

                    Console.WriteLine("Login Successful \n");
                    Console.WriteLine("Account Details : ");

                    Console.WriteLine("Company name : {0}", i.CompanyName);
                    Console.WriteLine("Email :- {0}", i.Email);
                    Console.WriteLine("Password :- {0}", i.Password);
                    Console.WriteLine("Website :- {0}", i.Website);
                    Console.WriteLine("Contact : - {0}", i.ContactNumber);
                    Console.WriteLine("Location :- {0}", i.Location);

                    if (loginSuccessful)
                    {
                        Interview[] schedule = new Interview[10];
                        string choose;
                        do
                        {
                            Console.WriteLine("****************************************");
                            Console.WriteLine("Choose the option :");
                            Console.WriteLine(" 1. Schedule Interview ");
                            Console.WriteLine(" 2. Scheduled Interview List ");
                            Console.WriteLine(" 3. Logout ");
                            Console.WriteLine("****************************************");

                            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------\n");
                            Console.WriteLine("Select an option");
                            string? Option = Console.ReadLine();

                            switch (Option)
                            {
                                case "1":
                                    {
                                        Console.WriteLine("How many Interviews are you scheduling? ");
                                        int count = Convert.ToInt32(Console.ReadLine());

                                        for (int k = 0; k < count; k++)
                                        {
                                            Console.WriteLine("--------------------------------------------------------Interview Schedule------------------------------------------------\n");

                                            Console.WriteLine("Enter the Name of Job post {0} : ", k + 1);
                                            schedule[k].Title = Console.ReadLine();

                                            Console.WriteLine("Enter the Date for Interview (dd-mm-yy) : ");
                                            string dateInput = Console.ReadLine();
                                            schedule[k].Date = DateTime.Parse(dateInput);

                                            Console.WriteLine("Enter the Time of the Interview (h-m) : ");
                                            schedule[k].Time = Console.ReadLine();

                                            Console.WriteLine("Location of scheduled Interview {0} : ", k + 1);
                                            schedule[k].Location = Console.ReadLine();
                                        }
                                        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------\n");
                                        break;
                                    }

                                case "2":
                                    {
                                        Console.WriteLine("------Scheduled interview list-------\n");
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------\n");

                                        for (int j = 0; j < schedule.Length; j++)
                                        {
                                            if (!string.IsNullOrEmpty(schedule[j].Title))
                                            {
                                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                                                Console.WriteLine("Name: {0}", schedule[j].Title);
                                                Console.WriteLine("Date: {0}", schedule[j].Date.Date.ToString("MM/dd/yyyy"));
                                                Console.WriteLine("Time: {0}", schedule[j].Time);
                                                Console.WriteLine("Location: {0}", schedule[j].Location);
                                            }
                                        }
                                        Console.ReadLine();
                                        break;
                                    }
                                case "3":
                                    {
                                        isLoggedIn = false;
                                        Console.WriteLine("Logged out successfully");
                                    }
                                    break;

                            }
                        } while (isLoggedIn);
                    }
                }
            }

            if (!loginSuccessful)
            {
                Console.WriteLine("Invalid Details");
            }
        }

        static void Exit()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}