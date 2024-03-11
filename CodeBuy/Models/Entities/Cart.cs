namespace CodeBuy.Models.Entities
{
    public class Cart : BaseEntity
    {
        public string CustomerId { get; set; } = default!;
        public Customer Customer { get; set; } = default!;
        public List<CartItem> Items { get; set;} = new List<CartItem>();

        public void AddItemToCart(List<CartItem> items)
        {
            Items.AddRange(items);
        }
    }

    public class CartItem
    {
        public string ProductId { get; set; } = default!;
        public string ProductName { get; set; } = default!;
        public int Quantity { get; set; } = default!;
        public decimal UnitPrice { get; set; } = default!;
    }
}
