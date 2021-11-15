namespace Ecommcerce2.BE
{
    public struct AvailableItems
    {
        public AvailableItems(string Name, string Description, double Price, int Quantity)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Quantity = Quantity;
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}