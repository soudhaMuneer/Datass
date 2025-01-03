// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());

if (i > j && i > k)
{
    Console.WriteLine(i + " is greater than " + j);
}
else
{
    Console.WriteLine(j + " is greater than " + i);
}

if (i % 2 == 0)
{
    Console.WriteLine(i + "is even");
}
else
{
    Console.WriteLine(i + "is odd");
}

