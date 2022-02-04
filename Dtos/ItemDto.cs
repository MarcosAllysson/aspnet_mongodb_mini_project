using System;

namespace Catalog.Dtos
{
    public record ItemDto
    {
        public Guid Id { get; init; } // init only properties. Set values only during inicialization
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}