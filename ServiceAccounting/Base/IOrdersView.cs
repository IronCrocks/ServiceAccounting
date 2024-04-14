using System;
using System.Collections.Generic;

namespace View.Base;

public interface IOrdersView : IView
{
    event EventHandler btnAddCustomerClicked;
    public void UpdateView(IEnumerable<object> data);
}
