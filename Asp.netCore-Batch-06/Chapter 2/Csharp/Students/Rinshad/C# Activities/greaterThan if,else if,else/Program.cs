using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 10;
            int b=20;
            int c = 30;

                   if (a >= b && b >= c) 

            {

                Console.WriteLine("Program greatest number is a"); }

                    else if (b >= c && a >= b) {
                Console.WriteLine("Program greatest number is b");
            }
            else
            {
                Console.WriteLine("Program greatest number is c");
            }
                
            }
           

        }
    }

