using ProductManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManager.Interface
{
    public interface IProduct
    {
        void AddProduct();
        void RemoveProduct(int id);
        List<Product> ListAllProducts();
    }
}
