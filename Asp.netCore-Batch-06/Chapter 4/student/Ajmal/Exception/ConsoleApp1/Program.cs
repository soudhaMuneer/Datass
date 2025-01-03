using ConsoleApp1.application;
using System;

namespace MyApp
{
    internal class Program
    {
        //static void sample(int age)
        //{
        //    if (age > 20)
        //    {
        //        throw new ArithmeticException("Access denied");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Accepted");
        //    }
        //}
        static void Main(string[] args)
        {


            string[] data=new string[3] ;
            int k = 0 ;
            foreach(string i in data )
            {
                Console.WriteLine("enter valid name !!!");
                string j = Console.ReadLine();
                try
                {
                    if (i == j)
                    {
                        throw new InavalidUserException(j);

                    }
                    else
                    {
                        data[k] = j;
                        k++;
                       

                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
            int[] num = new int[3] {1,2,3};
            foreach(int e in num){
                Console.WriteLine("enter valid number !!!");
                int j = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (e == j)
                    {
                        throw new InavalidUserException(j);

                    }
                    else
                    {
                        e= j;
                        k++;


                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }

            //try
            //{
            //    int a;
            //    a=Convert.ToInt32(Console.ReadLine());
            //    int b = a / 0;

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Invalid number");
            //}
        }
    }
}