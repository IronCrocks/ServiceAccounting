using Model.Data;

namespace Model.Services.Base;

public interface IOrdersService : IService
{
    void CreateOrder(Customer customer, IEnumerable<Product> products, DateTime date);
    OrderItem CreateOrderItem(Product product, int count);
    IEnumerable<object> GetOrders();
}
