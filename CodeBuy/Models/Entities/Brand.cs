namespace CodeBuy.Models.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public string Logo { get; set; } = default!;
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
