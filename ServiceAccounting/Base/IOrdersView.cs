using System;
using System.Collections.Generic;

namespace View.Base;

public interface IOrdersView : IView
{
    event EventHandler btnAddOrderClicked;
    public void UpdateView(IEnumerable<object> data);
    void Load();
}
