using System;
using System.Collections.Generic;

namespace ServiceAccounting.View.Base
{
    public interface IOrdersView : IView
    {
        public event EventHandler ViewLoaded;
        event EventHandler btnAddCustomerClicked;
        void UpdateView(IEnumerable<object> data);
    }
}
