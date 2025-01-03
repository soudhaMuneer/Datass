using System;

namespace Ref_Out
{
    internal class Program
    {
        public static string GetNextName(ref int id)
        {
            id= 0;
            string returnText = "Next-" + id.ToString();
            id += 1;
            return returnText;
        }
        public static string GetNextNames(out int id)
        {
            id = 0;
            string returnText = "Next-" + id.ToString();
        
            return returnText;
        }
        static void Main(string[] args)
        {
            int i = 1;
            //Console.WriteLine("Previous value of integer i:" + i.ToString());
            //string test = GetNextName(ref i);
            //Console.WriteLine(i);
            //Console.WriteLine("Current value of integer i:" + i.ToString());
            Console.WriteLine("Previous value of integer i:" + i.ToString());
            string test1 = GetNextNames(out i);
            Console.WriteLine(i);
            Console.WriteLine("Current value of integer i:" + i.ToString());
        }
      
    }
}