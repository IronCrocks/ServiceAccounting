using System;

namespace ServiceAccounting.View.Base
{
    public interface IProductsView : IView
    {
        event EventHandler RowUpdated;
        event EventHandler RowDeleted;
    }
}
