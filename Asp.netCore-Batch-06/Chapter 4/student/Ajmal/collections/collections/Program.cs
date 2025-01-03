using System;
using System.Collections;
namespace MyApp
{
    internal class Program
    {
        public struct job
        {
            public int id; 
            public string name;
            public string description;

        }
        static void Main(string[] args)
        {
            ArrayList jobs = new ArrayList();
            jobs.Add("Dotnet Devoleper");
            jobs.Add("Python Devoleper");
            jobs.Add("PHP Devoleper");
            
            foreach(var job in jobs)
            {
                Console.WriteLine(job);
            }
            Hashtable jobie = new Hashtable();
            jobie.Add("PHP Devoleper", 1);
            jobie.Add("Dotnet Devoleper",2);
            jobie.Add("Python Devoleper", 3);
            
            foreach (DictionaryEntry job in jobie)
            {
                Console.WriteLine($"{job.Key}{job.Value}");
            }
            Console.WriteLine();
            Queue jobss = new Queue();
            jobss.Enqueue("PHP Devoleper");
            jobss.Enqueue("Dotnet Devoleper");
            jobss.Enqueue("Python Devoleper");
            Console.WriteLine(jobss.Peek());
            while (jobss.Count > 0)
            {
              
                Console.WriteLine(jobss.Dequeue());
            }
            
            Console.WriteLine();
            Stack joblist = new Stack();
            joblist.Push("Python Devoleper");
            joblist.Push(".NET Devoleper");
            joblist.Push("Php Devoleper");
            while (joblist.Count > 0)
            {

                Console.WriteLine(joblist.Pop());
            }
            Console.WriteLine();
            SortedList sorting = new SortedList();
            sorting.Add("Php Devoleper", 2);

            sorting.Add("Python Devoleper", 3);
                      
            sorting.Add("ASP.NET Devoleper", 1);
            foreach (var keys in sorting.Keys)
            {
                Console.WriteLine($"{keys} {sorting[keys]}");
            }
            Console.WriteLine();
            List<string> lis = new List<string>();
            lis.Add(".NET Developer");
            lis.Add("PHP Developer");
            lis.Add("Python Developer");
            lis.Remove("Python Developer");
            foreach(string list in lis)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine();
            Dictionary<int,string> dic = new Dictionary<int, string>();
            dic.Add(1,"Data");
            dic.Add(2, "python");
            dic.Add(3, "D");
            Console.WriteLine(dic[3]);
            Console.WriteLine();

            SortedList <string,int> sorted = new SortedList<string, int>();
            sorted.Add("hai", 1);
            sorted.Add("hlo", 2);
            sorted.Add("hey", 3);
            sorted.Remove("hlo");
            Console.WriteLine(sorted[hey]);

        }
    }
}