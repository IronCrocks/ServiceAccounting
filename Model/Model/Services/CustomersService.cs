using ServiceAccounting.Model.Services.Base;
using ServiceAccounting.View.ViewEventArgs;
using System.Collections.Generic;
using System.Linq;

namespace ServiceAccounting.Model.Services;

public class CustomersService : ICustomersService
{
    public IEnumerable<object> GetCustomers()
    {
        using var dbContext = new ApplicationContext();
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

    public void AddCustomer(BtnAddCustomerClickedEventArgs e)
    {
        using var dbContext1 = new ApplicationContext();
        dbContext1.Customers.Add(new Customer { Name = e.Name, Age = e.Age });
        dbContext1.SaveChanges();
    }
}

