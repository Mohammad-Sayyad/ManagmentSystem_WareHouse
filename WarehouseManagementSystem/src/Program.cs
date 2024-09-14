using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.src
{
    class Program
    {
        static void Main(string[] args)
        {
            var electronicsManager = new ProductManager<Electronics>();
            var foodManager = new ProductManager<Food>();
            var clothingManager = new ProductManager<Clothing>();


            var phone = new Electronics("Smartphone", 1000, "Apple", "IPhone 13");
            var laptops = new Electronics("Laptop", 1600, "Dell", "XPS 15");

            var orange = new Food("Orange", 2.3, DateTime.Now.AddMonths(1));
            var milk = new Food("Milk", 3.6, DateTime.Now.AddDays(7));

            var Tshirts = new Clothing("T-Shirt", 23, "M", "Red");
            var Jeans = new Clothing("Jeans", 40, "L", "Blue");



            //Add Pprducts
            electronicsManager.AddProduct(phone);
            electronicsManager.AddProduct(laptops);

            foodManager.AddProduct(orange);
            foodManager.AddProduct(milk);

            clothingManager.AddProduct(Tshirts);
            clothingManager.AddProduct(Jeans);

            //Prints Products
            electronicsManager.DisplayProducts();
            foodManager.DisplayProducts();
            clothingManager.DisplayProducts();

            // RemoveProducts 
            electronicsManager.RemoveProduct(laptops);

           

        }
    }

}
