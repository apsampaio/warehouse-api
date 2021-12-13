using System;

namespace Warehouse.Entities
{
    public record Item
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public int Quantity { get; init; }
        public string Type { get; init; }
        public string Category { get; init; }
        public string Image { get; init; }
        public DateTimeOffset CreatedAt { get; init; }
        public DateTimeOffset UpdatedAt { get; init; }
    }
}