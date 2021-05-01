using System;

namespace Domain
{
    public class Product
    {
        public Guid Id { get; init; }

        public string Name { get; init; }
        public decimal Price { get; init; }
        public string PriceAsString => Price.ToString("C");
        public DateTimeOffset NextDelivery { get; init; }
    }
}