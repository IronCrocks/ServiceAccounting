using DTO;
using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface INewOrderView : IView
{
    public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;
    event EventHandler<OrderItemEventArgs> OrderItemAdded;

    void Load();
    void AddOrderItem(object item);
    void LoadData(IEnumerable<CustomerDTO> customers, IEnumerable<ProductDTO> products);
}
