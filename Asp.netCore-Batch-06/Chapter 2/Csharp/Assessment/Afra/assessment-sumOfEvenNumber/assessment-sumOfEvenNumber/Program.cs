using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_sumOfEvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,limit;
            int[] num = new int[10];
            Console.WriteLine("enter array limit");
            limit=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                num[i]= Convert.ToInt32(Console.ReadLine());
            }
          for(int i = 0;i < limit; i++)
            {
                if (num[i] % 2 == 0)
                {
                    sum=sum+num[i];
                }
            }
            Console.WriteLine("sum is {0}", sum);
            Console.ReadLine();
        }
    }
}
