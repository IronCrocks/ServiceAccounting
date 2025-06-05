using Model.Entites;
using Model.Projections;

namespace Model.Services.Base;

public interface IOrdersService : IService
{
    void CreateOrder(Customer customer, IEnumerable<OrderItem> orderItems, DateTime date);
    IEnumerable<OrderSummary> GetOrders();
    IEnumerable<CustomerOrderItem> GetOrders(Customer customer);
}
