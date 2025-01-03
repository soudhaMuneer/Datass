namespace oddOReven
{
    class oddOReven
    {
        public static void Main(string[] arg)
        {
            Console.WriteLine("Enter a Number");
            int a = Convert.ToInt32(Console.ReadLine());

            if(a % 2 ==0)
            {
                Console.WriteLine("The is Odd", a);
            }
            else
            {
                {
                    Console.WriteLine("The  is Odd" ,a);
                }
            }
        }
    }
}
