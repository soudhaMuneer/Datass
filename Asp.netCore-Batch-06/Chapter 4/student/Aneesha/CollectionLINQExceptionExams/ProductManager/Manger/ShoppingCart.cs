using ProductManager.Interface;
using ProductManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Manger
{
    public class ShoppingCart:IProduct
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1,Name = "Laptop",Price = 80000, Quantity = 1},
            new Product { Id = 2,Name = "Mobile",Price = 100000, Quantity = 2},
            new Product { Id = 3,Name = "Airpods",Price = 15000, Quantity = 3}
        };


        public List<Product> ListAllProducts()
        {
            foreach (var item in products)
            {
                Console.WriteLine($"Id : {item.Id} ,\n Name : {item.Name} ,\n Price : {item.Price} ,\n Quantity : {item.Quantity} ");
                Console.WriteLine("-----------------------------------");
            }
            return products;
        }
        public void AddProduct()
        {
            Console.Write("Enter Id :");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name :");
            string Name = Console.ReadLine();
            Console.Write("Enter Price :");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Quantity :");
            int Quantity = Convert.ToInt32(Console.ReadLine());
            double total = Price * Quantity;

            Product newProduct = new Product
            {
                Id = Id,
                Name = Name,
                Price = Price,
                Quantity = Quantity,
                TotalPrice = total,
            };
             products.Add(newProduct);
        }
        public void RemoveProduct(int id)
        {
            try
            {
                var removeItem = products.FirstOrDefault(s => s.Id == id);
                if (removeItem != null)
                {
                    products.Remove(removeItem);
                }
                
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("No products there");
            }

        }
        

        public void TotalPrice()
        {
            var total = products.Sum(s => s.TotalPrice);
            Console.WriteLine("Total Price is " + total);
        }
    }
}
