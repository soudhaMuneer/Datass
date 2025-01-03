using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_countVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a string");
            string str=Console.ReadLine();

            for (int i = 0; i < str.Length; i++) {
               
                if (str[i]=='a')
                {
                    count=count+1;
                }else if (str[i] == 'e')
                {
                    count=count+1;
                }else if (str[i] == 'i')
                {
                    count=count+1;
                }
                else if(str[i] == 'o'){
                    count=count+1;
                }
                else if (str[i]=='u')
                {
                    count=count+1;
                }
            }
            Console.WriteLine(" number of vowels are {0}",count);
            Console.ReadLine();
        }
    }
}
