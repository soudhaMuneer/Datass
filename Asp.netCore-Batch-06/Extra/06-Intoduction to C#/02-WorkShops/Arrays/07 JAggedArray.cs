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
          
            int[][] arr = new int[4][];

            
            arr[0] = new int[2] { 7, 9 };
            arr[1] = new int[4] { 12, 42, 26, 38 };
            arr[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
            arr[3] = new int[3] { 4, 6, 8 };

           
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i + 1);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();    
            Console.ReadLine();
        }
    }
    
}
