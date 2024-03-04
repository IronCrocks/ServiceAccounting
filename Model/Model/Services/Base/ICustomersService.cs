using ServiceAccounting.View.ViewEventArgs;
using System.Collections.Generic;

namespace ServiceAccounting.Model.Services.Base;

public interface ICustomersService : IService
{
    void AddCustomer(BtnAddCustomerClickedEventArgs e);
    IEnumerable<object> GetCustomers();
}
