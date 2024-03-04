using ServiceAccounting.View.ViewEventArgs;
using System.Collections.Generic;

namespace ServiceAccounting.Model.Services.Base;

public interface IOrdersService : IService
{
    IEnumerable<object> GetOrders();
}
