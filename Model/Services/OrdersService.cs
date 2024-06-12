using Model.Data;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class OrdersService : IOrdersService
{
    public IEnumerable<(string customerName, string productName, int count, int price, DateTime date)> GetOrders()
    {
        using var db = new ApplicationDBContext();

        var result = from customer in db.Customers
                     join order in db.Orders on customer.Id equals order.CustomerId
                     join orderItem in db.OrderItems on order.Id equals orderItem.OrderId
                     join product in db.Products on orderItem.ProductId equals product.Id
                     select new ValueTuple<string, string, int, int, DateTime>
                     (
                         customer.Name,
                         product.Name,
                         orderItem.Count,
                         product.Price,
                         order.Date
                     );

        return result.ToList();
    }

    public void CreateOrder(Customer customer, IEnumerable<OrderItem> orderItems, DateTime date)
    {
        using var db = new ApplicationDBContext();
        var order = new Order { CustomerId = customer.Id, Date = date };
        order.OrderItems.AddRange(orderItems);
        db.SaveChanges();
    }
}

