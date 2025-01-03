using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    public class ShoppingCart
    {
        private static List<Items> items=new List<Items>();
        int count = 0;
        private static int discountPercent = 0 ;
         public void applydiscount()
        {
            Console.WriteLine("Enter discount percentage");
            discountPercent = Convert.ToInt32(Console.ReadLine());
        }
        public void Additem()
        {
            
            
            Items item = new Items();
            item.Id = count;
            Console.WriteLine("Enter item name");
            item.Name = Console.ReadLine();
            Console.WriteLine("Enter item price");
            item.Prcice = Console.ReadLine();
            Console.WriteLine("Enter item quantity");
            item.Quantity = Console.ReadLine();
            items.Add(item);
            count++;
        }
        public void removeitem()
        {
            try
            {

                items.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void removeitem(Items item)
        {
            try
            {
                foreach (Items ite in items)
                {

                    if (ite.Name == item.Name)
                    {
                        items.Remove(ite);
                    }
                    else
                    {
                        throw new Exception("item not found");
                    }



                }
            }
            catch (Exception ex)
                {
                Console.WriteLine(ex.Message);
            }
            //try
            //{

            //    items.Contains(item);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

        }
        public void listitems()
        {
            foreach(Items ite in items)
            {
                Console.WriteLine(ite.Name+"price is"+ite.Prcice+"Quantity is"+ite.Quantity);
            }
        }
        public void PriceOfAllItem() 
        {
            int price;
            int quantity;
            float totalprice = 0;
            float dividedbyhundred;
            float finalbill;
            foreach (Items item in items)
            {
                
                price = Convert.ToInt32(item.Prcice);
                quantity = Convert.ToInt32(item.Quantity);
                totalprice += price*quantity;

            }
            float pp = totalprice;
            float dis = discountPercent;
            float discountamount = (pp * (dis / 100));
            finalbill = totalprice - discountamount;
            Console.WriteLine("============TOTAL PRICE is {0} WITH {1}% DISCOUNT============", finalbill, discountPercent);
        }
         
    }
}
