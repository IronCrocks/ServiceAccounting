using System;
using System.Collections.Generic;

namespace View.Base;

public interface IProductsView : IView
{
    event EventHandler RowUpdated;
    event EventHandler RowDeleted;
    public void UpdateView(IEnumerable<object> data);
}
