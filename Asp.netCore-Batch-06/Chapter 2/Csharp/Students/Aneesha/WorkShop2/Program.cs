namespace WorkShop2
{
    class WorkShop2
    {
        struct interview
        {
            public string title;
            public DateTime date;
            public string time;
            public string Location;
        }
        static void Main(string[] args)
        {
            interview[] shedule = new interview[10];

            Console.WriteLine("--------------------------------------------------Schedule an Interview For job Seekers---------------------------------------------------------\n");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------\n");

            string choose;
            do
            {
                Console.WriteLine("A - Schedule a interview \n");
                Console.WriteLine("D - Schedule interview List \n");


                Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------\n");
                Console.WriteLine("Select an option");
                string? Option = Console.ReadLine();

                switch (Option)
                {
                    case "A":
                        {
                            Console.WriteLine("How many Interviews are you scheduling? ");
                            int count = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine("--------------------------------------------------------Interview Schedule------------------------------------------------\n");

                                Console.WriteLine("Enter the Name of Job post {0} : ", i + 1);
                                shedule[i].title = Console.ReadLine();

                                Console.WriteLine("Enter the Date for Interview (dd-mm-yy) : ");
                                shedule[i].date = Convert.ToDateTime(Console.ReadLine());

                                Console.WriteLine("Enter the Time of the Interview (h-m) : ");
                                shedule[i].time = Console.ReadLine();

                                Console.WriteLine("Location of scheduled Interview {0} : ", i + 1);
                                shedule[i].Location = Console.ReadLine();
                            }
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------\n");
                            break;
                        }

                    case "D":
                        {
                            Console.WriteLine("------Scheduled interview list-------\n");
                            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------\n");

                            for (int i = 0; i < shedule.Length; i++)
                            {
                                if (shedule[i].title != null)
                                {
                                    Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
                                    Console.WriteLine("Name: {0}", shedule[i].title);
                                    Console.WriteLine("Date: {0}", shedule[i].date.Date.ToString("MM/dd/yyyy"));
                                    Console.WriteLine("Time: {0}", shedule[i].time);
                                    Console.WriteLine("Location: {0}", shedule[i].Location);
                                }
                            }
                            Console.ReadLine();
                            break;
                        }

                }


                Console.WriteLine("Do you want to continue (Y/N)\n ");
            choose = Console.ReadLine();

          } while(choose == "y" || choose == "Y");

        }
    }
}