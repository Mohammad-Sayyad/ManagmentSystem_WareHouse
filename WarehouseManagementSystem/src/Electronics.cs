namespace WarehouseManagementSystem.src
{
    public class Electronics : Product
    {
    // just a test
        public string Brand { get; set; }
        public string Model { get; set; }

        public Electronics(string name, double price, string brand, string model)
            : base(name, price)
        {
            Brand = brand;
            Model = model;
        }

        public override string GetProductInfo()
        {
            return $"Electronics - Name: {Name}, Price: {Price}, Brand: {Brand}, Model: {Model}";
        }
    }

}
