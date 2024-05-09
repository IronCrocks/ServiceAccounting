using Model.Data;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class CustomersService : ICustomersService
{
    public IEnumerable<object> GetCustomers()
    {
        using var dbContext = new ApplicationDBContext();
        var result = from customer in dbContext.Customers
                     join order in dbContext.Orders on customer.Id equals order.CustomerId into customersOrders
                     from customerOrders in customersOrders.DefaultIfEmpty()
                     join orderItem in dbContext.OrderItems on customerOrders.Id equals orderItem.OrderId into orderItemsCustomers
                     from orderItemCustomer in orderItemsCustomers.DefaultIfEmpty()
                     join product in dbContext.Products on orderItemCustomer.ProductId equals product.Id into gs
                     from g in gs.DefaultIfEmpty()
                     group (g.Price * orderItemCustomer.Count) by new { customer.Name, customer.Age } into x
                     select new
                     {
                         x.Key.Name,
                         x.Key.Age,
                         TotalSum = x.Sum()
                     };
        return result.ToList();
    }

    public void AddCustomer(string name, int age)
    {
        using var dbContext = new ApplicationDBContext();
        dbContext.Customers.Add(new Customer { Name = name, Age = age });
        dbContext.SaveChanges();
    }

    public Customer GetCustomer(int id)
    {
        using var dbContext = new ApplicationDBContext();
        return dbContext.Customers.FirstOrDefault(p => p.Id == id);
    }
}

