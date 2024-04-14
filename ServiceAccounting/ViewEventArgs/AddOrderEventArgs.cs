using System;
using System.Collections.Generic;

namespace View.ViewEventArgs;

public class AddOrderEventArgs : EventArgs
{
    public AddOrderEventArgs(IEnumerable<object> products, object customer, DateTime date)
    {
        Products = products ?? throw new ArgumentNullException(nameof(products));
        Customer = customer ?? throw new ArgumentNullException(nameof(customer));
        Date = date;
    }

    public IEnumerable<object> Products { get; set; }
    public object Customer { get; set; }
    public DateTime Date { get; set; }
}
