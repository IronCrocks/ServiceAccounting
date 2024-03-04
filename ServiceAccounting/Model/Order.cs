﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServiceAccounting.Model;

public class Order
{
    public int Id { get; set; }
    [Required]
    public string Number { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;

    public List<Product> Products { get; set; } = new List<Product>();
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public Customer? Customer { get; set; }
    public int CustomerId { get; set; }
}
