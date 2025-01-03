// See https://aka.ms/new-console-template for more information

namespace dynamicArray
{
    class programm
    {
        static void Main(string[] args)
        {
            string[] students = new string[4] { "Shemeem", "shaid", "abid", "ajmal" };
            Console.WriteLine(students[3]);
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            ////////////////////////////////////////////////////////////////////////
            ///

            int firstnumber = 5;
            int secondnumber = 6;
            Console.WriteLine("firstnumber = "+ firstnumber + " secondnumber = " + secondnumber);
            int thirdnumber = firstnumber;
            firstnumber = secondnumber;
            secondnumber = thirdnumber;
           Console.WriteLine("firstnumber = " + firstnumber + " secondnumber = " + secondnumber);

            //////////////////////////////////////////////////////////////////////////////////////
            ///
            int num = 5;
            
            for(int i = 0;i <11; i++)
            {
                Console.WriteLine(num+ " * "+i+" = "+  i*num);
            }
            Console.WriteLine("a = ");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("d = ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("e = ");
            int e = Convert.ToInt32(Console.ReadLine());
            int add = a + b + c + d+e;
            int avg = add / 5;
            Console.WriteLine("average = "+avg);

            /////////////////////////////////////////////////////////////////////////////
            ///
            int inp;
            Console.WriteLine();
             inp= Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}{0}{0}{0}", inp);
            Console.WriteLine();
            Console.Write("{0} {0} {0} {0}", inp);
            Console.WriteLine();
            Console.Write("{0}{0}{0}{0}", inp);
            Console.WriteLine();
            Console.Write("{0} {0} {0} {0}", inp);

        }
    }
}