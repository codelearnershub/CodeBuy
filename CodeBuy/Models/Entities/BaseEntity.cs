﻿namespace CodeBuy.Models.Entities
{
    public abstract class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public string CreatedBy { get; set; } = default!;
        public string? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
