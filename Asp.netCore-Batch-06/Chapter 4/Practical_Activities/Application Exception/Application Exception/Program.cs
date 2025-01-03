using Application_Exception.Exceptions;
using System;

namespace Application_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("enter a number");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a);
                if (a == 2)
                {
                    throw new InvalidDivisionException(a);
                }
            }
            catch(InvalidDivisionException ex) {
                Console.WriteLine(ex.Message);           
            }
            catch(Exception ex)
            {
                Console.WriteLine("this is for string"+ex.Message);
            }
         
            Console.ReadKey();
        }
    }
}
