using System;

namespace View.ViewEventArgs;

public class AddCustomerEventArgs : EventArgs
{
    public string Name { get; set; }
    public int Age { get; set; }
}
