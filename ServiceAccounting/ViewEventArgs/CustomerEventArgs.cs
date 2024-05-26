using DTO;
using System;

namespace View.ViewEventArgs;

public class CustomerEventArgs : EventArgs
{
    public CustomerDTO Customer { get; set; }
    public CustomerEventArgs(CustomerDTO customerDTO)
    {
        Customer = customerDTO ?? throw new ArgumentNullException(nameof(customerDTO));
    }
}
