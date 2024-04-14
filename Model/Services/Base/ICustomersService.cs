using Model.Data;

namespace Model.Services.Base;

public interface ICustomersService : IService
{
    void AddCustomer(string name, int age);
    Customer GetCustomer(int id);
    IEnumerable<object> GetCustomers();
}
