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

		//declare array list

            ArrayList list = new ArrayList();

		//Add value to array list

            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

		//foreach using array list

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
    
}
