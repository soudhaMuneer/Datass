using Shoppingcart;
using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart Shoppingcart = new ShoppingCart();
            while (true)
            {
                Shoppingcart.PriceOfAllItem();
                Shoppingcart.listitems();
                Console.WriteLine("Enter your choice\n 1.Add item \n 2.Remove items\n 3.Apply discount");


                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Shoppingcart.Additem();

                            break;
                        case 2:
                            Items item = new Items();
                            Console.WriteLine("Enter item name");
                            item.Name = Console.ReadLine();
                            Shoppingcart.removeitem(item);
                            break;
                        case 3:
                            Shoppingcart.applydiscount();

                            break;
                        default:
                            Console.WriteLine("Enter valid choice");
                            break;
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}