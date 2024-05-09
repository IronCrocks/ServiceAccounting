using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface IProductsView : IView
{
    event EventHandler RowInserted;
    event EventHandler<RowRemovedEventArgs> RowRemoved;
    event EventHandler<ObjectUpdatedEventArgs> RowUpdated;

    public void LoadData(IEnumerable<object> data);
    public List<object> Products { get; set; }
    public void Load();
    void UpdateView();
}
