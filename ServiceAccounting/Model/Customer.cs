using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceAccounting.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}
