using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface INewOrderView : IView
{
    public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;
    event EventHandler<AddOrderItemEventArgs> OrderItemAdded;

    public void UpdateView(IEnumerable<object> customers, IEnumerable<object> products);
    void Load();
    void AddOrderItem(object item);
}
