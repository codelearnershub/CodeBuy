namespace CodeBuy.Models.Entities
{
    public class ProductCategory : BaseEntity
    {
        public string ProductId { get; set; } = default!;
        public Product Product { get; set; } = default!;
        public string CategoryId { get; set; } = default!;
        public Category Category { get; set; } = default!;
    }
}
