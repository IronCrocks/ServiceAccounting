﻿namespace Model.Projections
{
    public class OrderSummary
    {
        public string CustomerName { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public int Count { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
