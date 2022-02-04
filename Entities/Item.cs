using System;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; init; } // init only properties. Set values only during inicialization
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}