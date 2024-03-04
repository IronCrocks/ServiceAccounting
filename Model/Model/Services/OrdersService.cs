using ServiceAccounting.Model.Services.Base;
using System.Collections.Generic;
using System.Linq;

namespace ServiceAccounting.Model.Services;

public class OrdersService : IOrdersService
{
    public IEnumerable<object> GetOrders()
    {
        using var db = new ApplicationContext();

        var result = from customer in db.Customers
                     join order in db.Orders on customer.Id equals order.CustomerId
                     join orderItem in db.OrderItems on order.Id equals orderItem.OrderId
                     join product in db.Products on orderItem.ProductId equals product.Id
                     select new
                     {
                         customer.Name,
                         productName = product.Name,
                         orderItem.Count,
                         product.Price,
                         order.Date
                     };

        return result.ToList();
    }
}

