using DTO;
using System;

namespace View.ViewEventArgs;

public class CustomerEventArgs : EventArgs
{
    public CustomerEventArgs(CustomerDTO customerDTO)
    {
        Customer = customerDTO ?? throw new ArgumentNullException(nameof(customerDTO));
    }

    public CustomerDTO Customer { get; }
}
