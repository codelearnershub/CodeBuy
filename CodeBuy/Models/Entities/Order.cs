using CodeBuy.Models.Enums;

namespace CodeBuy.Models.Entities
{
    public class Order : BaseEntity
    {
        public string ReferenceNumber { get; set; } = default!;
        public OrderStatus Status { get; set; } = default!;
    }
}
