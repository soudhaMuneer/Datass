using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BAsicProgramming
{
    class Readall
    {
       
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");

            char c = Convert.ToChar(Console.ReadLine());
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("The character is lowercase.");
                }
                else
                {
                    Console.WriteLine("The character is uppercase.");
                }
            }
            else
            {
                Console.WriteLine("Not an alphabetic character.");
            }
            Console.ReadLine();
        }
    }
    
}
