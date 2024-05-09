using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface ICustomersView : IView
{
    event EventHandler<AddCustomerEventArgs> btnAddCustomerClicked;
    public void UpdateView(IEnumerable<object> data);
    void Load();
}