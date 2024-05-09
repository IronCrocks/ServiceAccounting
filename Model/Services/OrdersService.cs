using Model.Data;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class OrdersService : IOrdersService
{
    public IEnumerable<object> GetOrders()
    {
        using var db = new ApplicationDBContext();

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

    public void CreateOrder(Customer customer, IEnumerable<Product> products, DateTime date)
    {
        using var db = new ApplicationDBContext();

        var order = new Order { CustomerId = customer.Id, Date = date };

        foreach (var product in products)
        {
            var orderItem = new OrderItem
            {
                ProductId = product.Id,
                Count = 1
            };

            order.OrderItems.Add(orderItem);
        }

        db.Orders.Add(order);
        db.SaveChanges();
    }
}

