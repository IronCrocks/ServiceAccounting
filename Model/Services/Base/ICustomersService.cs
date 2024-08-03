using Model.Data;

namespace Model.Services.Base;

public interface ICustomersService : IService
{
    int AddCustomer(Customer customer);
    void DeleteCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    Customer? GetCustomerById(int id);
    IEnumerable<(int Id, string Name, int Age, int TotalSum)> GetCustomers();
}
