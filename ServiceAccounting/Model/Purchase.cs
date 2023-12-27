﻿using System;

namespace ServiceAccounting.Model;

internal class Purchase
{
    public int Id { get; set; }
    public int Count { get; set; }
    public DateTime Date { get; set; }

    public Product Product { get; set; }
    public int ProductId { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
}