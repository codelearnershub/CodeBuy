namespace CodeBuy.Models.Entities
{
    public class Seller : BaseEntity
    {
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string LogoUrl { get; set; } = default!;
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
