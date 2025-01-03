using System.Linq.Expressions;

namespace Exception
{
    class Exception
    {
        static void Main(string[] args)
        {
            ///////////////system exception///////////////////

            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{ 
            //    Console.WriteLine("Not Valid");
            //}

            //try
            //{
            //    int num1 = 5;
            //    int num2 = 0;
            //    int div = num1/ num2;

            //}
            //catch(FormatException) 
            //{
            //    Console.WriteLine("Error : invalid input");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You tired to divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Thanks for visiting");
            //}

            ///////////////system exception///////////////////

            ///////////////application exception//////////////

            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    int a = Convert.ToInt32(Console.ReadLine());   

            //    Console.WriteLine(array[a]);
            //}
            //catch(IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            try
            {
                int[] number = new int[5];
                
                for(int i = 0; i < number.Length; i++)
                {
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine("array type" + ex.Message);
            }

        }
    }
}
