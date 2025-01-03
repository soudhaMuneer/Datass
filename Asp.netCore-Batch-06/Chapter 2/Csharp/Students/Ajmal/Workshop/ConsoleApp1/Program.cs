// See https://aka.ms/new-console-template for more information
namespace Postjob
{7
    public class Program
    {
        struct Job
        {
            public string? jobtitle;
            public string? jobdescription;
            public DateTime datetime;
            public int salary;
            public string? place;
        }
        static Job[] Jobbs = new Job[5];
        static int count = 0;
        
        static void Main(string[] args)
        {
           

            string? ch;
            do
            {
                Console.WriteLine("***************************************** Welcome to Jobie **************************************");
                Console.WriteLine();
                Console.WriteLine("1. Add New Job\n2. View Jobs");
                Console.WriteLine();
                int inp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();


                switch (inp)
                {
                    case 1:
                        Job jobs = new Job();

                        Console.WriteLine("How many Jobs You Want to add \n");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("{0} Job title", i + 1);

                            jobs.jobtitle = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("{0} Job Description", i + 1);

                            jobs.jobdescription = Console.ReadLine();
                            Console.WriteLine();

                            Console.WriteLine("{0} Job End Date", i + 1);

                            jobs.datetime = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("{0} Job Salary", i + 1);

                            jobs.salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("{0} Job Place", i + 1);

                            jobs.place = Console.ReadLine();
                            Console.WriteLine();
                        }

                        Jobbs[count] = jobs ;
                        count++;


                        break;
                    case 2:

                        for (int i = 0; i < Jobbs.Length; i++)
                        {
                            
                            Console.WriteLine(Jobbs[i].jobtitle);
                            Console.WriteLine();
                        }
                        break;
                }
                Console.WriteLine("Do you want continue Y/N");
                ch = Console.ReadLine();

            } while (ch == "Y"|| ch=="y");
        }
    }
}
