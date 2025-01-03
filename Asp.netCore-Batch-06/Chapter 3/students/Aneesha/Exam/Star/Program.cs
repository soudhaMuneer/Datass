namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int a = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < a; ++i)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine("");
            //    }
            //    Console.WriteLine("");
            //}


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a + "*" + i + "=" + i * a);
            }

        }
    }
}

