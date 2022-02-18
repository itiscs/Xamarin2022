using System;
using System.Collections.Generic;
using System.Text;

namespace App4
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            var lst = new List<Product>();
            lst.Add(new Product
            {
                Id = 1,
                Name = "Яблоки",
                Description = "Яблоки",
                Price = 80
            });
            lst.Add(new Product
            {
                Id = 2,
                Name = "Груши",
                Description = "Груши",
                Price = 180
            });
            lst.Add(new Product
            {
                Id = 3,
                Name = "Бананы",
                Description = "Бананы",
                Price = 40
            });
            lst.Add(new Product
            {
                Id = 4,
                Name = "Яблоки",
                Description = "Яблоки",
                Price = 80
            });
            lst.Add(new Product
            {
                Id = 5,
                Name = "Груши",
                Description = "Груши",
                Price = 180
            });
            lst.Add(new Product
            {
                Id = 6,
                Name = "Бананы",
                Description = "Бананы",
                Price = 40
            });
            lst.Add(new Product
            {
                Id = 7,
                Name = "Яблоки",
                Description = "Яблоки",
                Price = 80
            });
            lst.Add(new Product
            {
                Id = 8,
                Name = "Груши",
                Description = "Груши",
                Price = 180
            });
            lst.Add(new Product
            {
                Id = 9,
                Name = "Бананы",
                Description = "Бананы",
                Price = 40
            });
            return lst;

        }

    }
}
