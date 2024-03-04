using ServiceAccounting.Model;
using System;

namespace ServiceAccounting.View.ViewEventArgs
{
    public class BtnAddOrderClickedEventArgs : EventArgs
    {
        public Order Order { get; set; }
    }
}
