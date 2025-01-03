namespace MyApp
{
    internal class Find
    {
        static void Main(string[] args)
        {

            string[] fruitArray = new string[]
            {
                "apple","orange","jackfruit","dragonfriut","bannana"
            };
            foreach (string fruit in fruitArray)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
