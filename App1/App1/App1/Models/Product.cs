using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
   
    [Table("Products")]
    public class Product
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(100)]
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
                Description = "Яблоки Голден",
                Price = 100
            });
            lst.Add(new Product
            {
                Id = 2,
                Name = "Груши",
                Description = "Груши Конференс",
                Price = 230
            });

            lst.Add(new Product
            {
                Id = 1,
                Name = "Бананы",
                Description = "Бананы",
                Price = 80
            });
            return lst;
        }

    }
}
