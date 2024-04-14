using Model.Data;

namespace Model.Services.Base;

public interface IOrdersService : IService
{
    void CreateOrder(Customer customer, IEnumerable<Product> products, DateTime date);
    IEnumerable<object> GetOrders();
}
