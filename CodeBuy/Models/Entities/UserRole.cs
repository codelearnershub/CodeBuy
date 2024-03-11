namespace CodeBuy.Models.Entities
{
    public class UserRole : BaseEntity
    {
        public string UserId { get; set; } = default!;
        public User User { get; set; } = default!;
        public string RoleId { get; set; } = default!;
        public Role Role { get; set; } = default!;
    }
}
