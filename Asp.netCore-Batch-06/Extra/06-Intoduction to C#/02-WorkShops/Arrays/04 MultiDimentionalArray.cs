using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BAsicProgramming
{
     class Management
    {

        static void Main(string[] args)
        {
            
            int[,] arr = new int[4, 3];

            
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Enter row element : {0}", x + 1);
                for (int y = 0; y < 3; y++)
                {
                    arr[x, y] = Int32.Parse(Console.ReadLine());
                }
            }

            
            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine("Values of row : {0}", x + 1 );

                for (int y = 0; y < 3; y++)
                {
                    Console.WriteLine();
                    
                    Console.Write(arr[x, y] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
    
}
