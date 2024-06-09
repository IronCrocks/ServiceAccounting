using DTO;
using System;

namespace View.ViewEventArgs;

public class OrderItemEventArgs : EventArgs
{
    public OrderItemEventArgs(OrderItemDTO orderItem)
    {
        OrderItemDTO = orderItem ?? throw new ArgumentNullException(nameof(orderItem));
    }

    public OrderItemDTO OrderItemDTO { get; set; }
}
