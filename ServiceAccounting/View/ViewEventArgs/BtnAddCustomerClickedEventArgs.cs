using System;

namespace ServiceAccounting.View.ViewEventArgs;

public class BtnAddCustomerClickedEventArgs : EventArgs
{
    public string Name { get; set; }
    public int Age { get; set; }
}
