using DTO;
using System;
using System.Collections.Generic;

namespace View.Base;

public interface IOrdersView : IView
{
    event EventHandler btnAddOrderClicked;

    void Load();
    void UpdateView(IEnumerable<OrderDTO> orders);
}
