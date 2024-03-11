namespace CodeBuy.Models.Entities
{
    public class Product : BaseEntity
    {
        public string SellerId { get; set; } = default!;
        public Seller Seller { get; set; } = default!;
        public string BrandId { get; set; } = default!;
        public Brand Brand { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public double Price { get; set; } = default!;
        public int Quantity { get; set; } = default!;
        public object? Data { get; set; } = default!;
        public List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();

    }
}
