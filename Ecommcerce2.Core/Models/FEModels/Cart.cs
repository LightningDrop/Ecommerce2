namespace Ecommcerce2.Core.Models.FEModels
{
    public class Cart
    {
        // 1 Cart to 1 Account 
        public int Id { get; set; }
        public int AccountId { get; set; } // FK AccountId 

        IEnumerable<TransactionItem> Items { get; set; } // A cart holds a list of items 

    }
}
