using Model.Entites;
using Model.Projections;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class OrdersService : IOrdersService
{
    public IEnumerable<OrderSummary> GetOrders()
    {
        using var db = new ApplicationDBContext();

        var lastmonth = DateTime.Now.AddMonths(-1);

        var result = from customer in db.Customers
                     join order in db.Orders on customer.Id equals order.CustomerId
                     join orderItem in db.OrderItems on order.Id equals orderItem.OrderId
                     join product in db.Products on orderItem.ProductId equals product.Id
                     where order.Date >= lastmonth
                     select new OrderSummary
                     {
                         CustomerName = customer.Name,
                         ProductName = product.Name,
                         Count = orderItem.Count,
                         Price = product.Price,
                         Date = order.Date
                     };

        return result.ToList();
    }

    public IEnumerable<CustomerOrderItem> GetOrders(Customer customer)
    {
        using var db = new ApplicationDBContext();

        var ordersData = db.Customers
            .Where(c => c.Id == customer.Id)
            .SelectMany(c => c.Orders)
            .SelectMany(o => o.OrderItems)
            .Select(oi => new CustomerOrderItem
            {
                Date = oi.Order.Date,
                Name = oi.Product.Name,
                Count = oi.Count,
                Price = oi.Product.Price
            }).ToList();

        return ordersData;
    }

    public void CreateOrder(Customer customer, IEnumerable<OrderItem> orderItems, DateTime date)
    {
        using var dbContext = new ApplicationDBContext();
        var order = new Order { CustomerId = customer.Id, Date = date };
        order.OrderItems.AddRange(orderItems);
        dbContext.Orders.Add(order);
        dbContext.SaveChanges();
    }
}

