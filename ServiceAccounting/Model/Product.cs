using System.Collections.Generic;

namespace ServiceAccounting.Model;

internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    public List<Customer> Customers { get; set; } = new List<Customer>();
    public List<Purchase> Purchases { get; set; } = new List<Purchase>();
}
