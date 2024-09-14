using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.src
{
    public class ProductManager<T> where T : IProduct
    {
        private List<T> products = new List<T>();


        public void AddProduct(T product)
        {
            products.Add(product);
            Console.WriteLine($"{product.GetProductName()} added to the inventory");
        }

        public void RemoveProduct(T product)
        {
            products.Remove(product);
            Console.WriteLine($"{product.GetProductName()} removed from the inventory.");
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Inventory");
            foreach (var product in products)
            {
                Console.WriteLine(product.GetProductInfo());
            }
        }

    }
}
