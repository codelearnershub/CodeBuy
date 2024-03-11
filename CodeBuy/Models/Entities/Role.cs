namespace CodeBuy.Models.Entities
{
    public class Role : BaseEntity
    {
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
    }
}
