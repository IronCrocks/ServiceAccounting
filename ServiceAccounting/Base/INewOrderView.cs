using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface INewOrderView : IView
{
    public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;
    public void UpdateView(IEnumerable<object> customers, IEnumerable<object> products);
    void Load();
}
