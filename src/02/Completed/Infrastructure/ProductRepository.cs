using System;
using System.Collections.Generic;

using Domain;

namespace Infrastructure
{
    public class ProductRepository
    {
        private IEnumerable<Product> products;

        public ProductRepository()
        {
            products = new List<Product>()
            {
                new Product {
                    Id = Guid.Parse("fd1b4932-7699-40b7-abe6-c7c98d52b298"),
                    Name = "Eggs",
                    Price = 2.99m,
                    NextDelivery = new DateTime(2021, 03, 01, 0, 0, 0)
                },
                new Product
                {
                    Id = Guid.Parse("31f46620-302c-4873-b213-794abdd7ca7a"),
                    Name = "Milk",
                    Price = 1.24m,
                    NextDelivery = new DateTime(2021, 02, 01, 0, 0, 0)
                },
                new Product
                {
                    Id = Guid.Parse("e9999aa8-9306-463f-a0a9-13efffcd1d1f"),
                    Name = "Bananas",
                    Price = 3.99m,
                    NextDelivery = new DateTime(2021, 01, 01, 0, 0, 0)
                },
                new Product
                {
                    Id = Guid.Parse("70b27eb0-0ad3-48ea-97bb-e02e27b4758e"),
                    Name = "Soda (big pack)",
                    Price = 29.99m,
                    NextDelivery = new DateTime(2021, 01, 01, 0, 0, 0)
                }
            };
        }

        public IEnumerable<Product> Get()
        {
            return products;
        }
    }
}
