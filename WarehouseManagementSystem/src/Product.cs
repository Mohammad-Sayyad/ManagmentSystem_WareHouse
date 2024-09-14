namespace WarehouseManagementSystem.src
{
    public abstract class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        protected Product(string name , double price)
        {
            Name = name;
            Price = price;
        }
        public abstract string GetProductInfo();
        
        public string GetProductName()
        {
            return Name;
        }
    }
}
