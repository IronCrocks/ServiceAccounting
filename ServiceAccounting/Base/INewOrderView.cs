using DTO;
using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface INewOrderView : IView
{
    public event EventHandler<AddOrderEventArgs> BtnAddOrderClicked;
    event EventHandler<ProductEventArgs> OrderItemAdded;
    event EventHandler<OrderItemEventArgs> OrderItemDeleted;

    void Load();
    void LoadData(IEnumerable<CustomerDTO> customers, IEnumerable<ProductDTO> products);
    void AddOrderItem(OrderItemDTO item);
}
