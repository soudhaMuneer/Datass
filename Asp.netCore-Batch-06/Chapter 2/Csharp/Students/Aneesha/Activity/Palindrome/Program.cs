namespace Palindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int a, b, sum = 0, temp;
            Console.WriteLine("Enter a number");
            a = Convert.ToInt32(Console.ReadLine());
            temp = a;
            while (a > 0)
            {
                b = a % 10;
                sum = (sum * 10) + b;
                a = a / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }
        }
    }
}
