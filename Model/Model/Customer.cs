using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceAccounting.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }

        public List<Product> Products { get; set; } = new List<Product>();
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
