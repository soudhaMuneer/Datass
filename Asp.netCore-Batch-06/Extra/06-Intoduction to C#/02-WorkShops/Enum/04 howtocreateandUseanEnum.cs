using System;
namespace BAsicProgramming
{
    public enum DayofWeek
    {
        Sunday = 1, Monday, Tuesday = 1, Wednesday, Thursday = 2, Friday, Saturday
    }
     class Management
    {
         
        static void Main(string[] args)
        {
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Sunday, DayOfWeek.Sunday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Monday, DayOfWeek.Monday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Tuesday, DayOfWeek.Tuesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Wednesday, DayOfWeek.Wednesday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Thursday, DayOfWeek.Thursday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Friday, DayOfWeek.Friday);
            Console.WriteLine("Day of week {0} {1}", (int)DayOfWeek.Saturday, DayOfWeek.Saturday);
            Console.ReadLine();
        }
    }
    
}
