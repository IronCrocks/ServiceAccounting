using DTO;
using System;
using System.Collections.Generic;
using View.ViewEventArgs;

namespace View.Base;

public interface ICustomersView : IView
{
    event EventHandler<CustomerEventArgs> CustomerAdded;
    event EventHandler<CustomerEventArgs> CustomerDeleted;
    event EventHandler<CustomerEventArgs> CustomerChanged;

    public void LoadCustomers(IEnumerable<CustomerDTO> customers);
    public void Load();
}