using ProductManager.Manger;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {

            ShoppingCart cart = new ShoppingCart();

            Console.WriteLine("Welcome to shoppimg cart");
            while (true)
            {
                Console.WriteLine("1.List all products");
                Console.WriteLine("2.Add Item");
                Console.WriteLine("3.Remove Item");
                Console.WriteLine("4.Total price");

                Console.WriteLine("choose an option");
                string choose = Console.ReadLine(); 

                switch (choose)
                {
                    case "1":
                      cart.ListAllProducts();
                        break;
                        case "2":
                        cart.AddProduct();
                        break;
                        case "3":
                        Console.WriteLine("Enter ID you want to edit");
                        int id = Convert.ToInt32(Console.ReadLine());
                        cart.RemoveProduct(id);
                        break;
                        case "4":
                        cart.TotalPrice();
                        break;
                }
            }
        }
    }
}
