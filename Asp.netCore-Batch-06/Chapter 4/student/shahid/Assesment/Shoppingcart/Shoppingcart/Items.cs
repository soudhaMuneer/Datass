using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcart
{
    public class Items
    {
        public int Id { get; set; } 
        public string Name {  get; set; }
        public string Prcice { get; set; }
        public string Quantity { get; set; }

        public Items() { }

        public Items(string name, string prcice, string quantity)
        {
            Name = name;
            Prcice = prcice;
            Quantity = quantity;
        }
    }
}
