namespace WarehouseManagementSystem.src
{
    public class Clothing : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothing(string name , double price , string size , string color) : base(name , price)
        {
            Size = size;
            Price = price;
        }

        public override string GetProductInfo()
        {
            return $"Clothing - Name: {Name} , Price: {Price} , Size: {Size} , Color: {Color}";
        }
    }
}
