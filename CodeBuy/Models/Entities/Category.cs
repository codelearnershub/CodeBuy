namespace CodeBuy.Models.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    }
}
