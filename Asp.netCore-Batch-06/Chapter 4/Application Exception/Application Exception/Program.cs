using Application_Exception.Exceptions;
using System;

namespace Application_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a);
            try
            {
                if (a == 2)
                {
                    throw new InvalidDivisionException(a);
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);            }
         
            Console.ReadKey();
        }
    }
}
