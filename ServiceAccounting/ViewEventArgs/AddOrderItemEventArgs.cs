using System;

namespace View.ViewEventArgs;

public class AddOrderItemEventArgs : EventArgs
{
    public AddOrderItemEventArgs(object product, int count)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(count);

        Product = product ?? throw new ArgumentNullException(nameof(product));
        Count = count;
    }
    public object Product { get; set; }
    public int Count { get; }
}
