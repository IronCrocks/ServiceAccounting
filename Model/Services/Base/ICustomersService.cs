using Model.Data;

namespace Model.Services.Base;

public interface ICustomersService : IService
{
    int AddCustomer(Customer customer);
    void DeleteCustomer(Customer customer);
    void UpdateCustomer(Customer customer);
    Customer? GetCustomerById(int id);
    IEnumerable<CustomerOrderSummary> GetCustomers();
}
