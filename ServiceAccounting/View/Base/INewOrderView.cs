using ServiceAccounting.View.ViewEventArgs;
using System;

namespace ServiceAccounting.View.Base
{
    public interface INewOrderView : IView
    {
        public event EventHandler<BtnAddOrderClickedEventArgs> BtnAddOrderClicked;
    }
}
