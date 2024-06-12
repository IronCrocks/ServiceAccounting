using Model.Data;

namespace Model.Services.Base;

public interface IOrdersService : IService
{
    void CreateOrder(Customer customer, IEnumerable<OrderItem> orderItems, DateTime date);
    IEnumerable<(string customerName, string productName, int count, int price, DateTime date)> GetOrders();
}
