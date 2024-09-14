namespace WarehouseManagementSystem.src
{
    public class Food : Product
    {
        public DateTime ExpirationDate { get; set; }
        public Food(string name , double price , DateTime expirationDate) : base(name,price)
        {
            this.ExpirationDate = expirationDate;
        }

        public override string GetProductInfo()
        {
            return $"Food - Name: {Name} , Price; {Price} , Expiration Date: {ExpirationDate}";
        }
    }
}
