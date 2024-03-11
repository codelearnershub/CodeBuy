using CodeBuy.Models.Enums;

namespace CodeBuy.Models.Entities
{
    public class User : BaseEntity
    {
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string PhoneNumber { get; set; } = default!;
        public string ImageUrl { get; set; } = default!;
        public Seller Seller { get; set; } = default!;
        public Customer Customer { get; set; } = default!;
        public List<UserRole> UserRoles { get; set; } = new List<UserRole>();
    }
}
