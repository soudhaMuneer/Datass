namespace pyramid
{
    class Pyramid
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int i, j;
            //for (i = 1; i <= a; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            ///////////

            //int i, j, k = 1;
            //for (i = 1; i <= 5; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0} ", k++);
            //    }

            //    Console.WriteLine();
            //}



            /////////////

            Console.WriteLine("Enter the number");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }


                for (int k = 0; k < a - i; k++)
                {
                    Console.Write("  * ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
            //////////

        }
    }
}
