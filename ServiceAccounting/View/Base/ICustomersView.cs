using ServiceAccounting.View.ViewEventArgs;
using System;
using System.Collections.Generic;

namespace ServiceAccounting.View.Base;

public interface ICustomersView : IView
{
    event EventHandler ViewLoaded;
    event EventHandler<BtnAddCustomerClickedEventArgs> btnAddCustomerClicked;
    void UpdateView(IEnumerable<object> data);
}