namespace CodeBuy.Models.Entities
{
    public class Customer : BaseEntity
    {
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;
        public Cart Cart { get; set; } = default!;
    }


}
