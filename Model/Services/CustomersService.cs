﻿using Model.Entites;
using Model.Projections;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class CustomersService : ICustomersService
{
    public IEnumerable<CustomerOrderSummary> GetCustomers()
    {
        using var dbContext = new ApplicationDBContext();

        var result = from customer in dbContext.Customers
                     join order in dbContext.Orders on customer.Id equals order.CustomerId into customersOrders
                     from customerOrders in customersOrders.DefaultIfEmpty()
                     join orderItem in dbContext.OrderItems on customerOrders.Id equals orderItem.OrderId into orderItemsCustomers
                     from orderItemCustomer in orderItemsCustomers.DefaultIfEmpty()
                     join product in dbContext.Products on orderItemCustomer.ProductId equals product.Id into gs
                     from g in gs.DefaultIfEmpty()
                     group (g.Price * orderItemCustomer.Count) by new { customer.Id, customer.Name, customer.Age } into x
                     select new CustomerOrderSummary()
                     {
                         Age = x.Key.Age,
                         Id = x.Key.Id,
                         Name = x.Key.Name,
                         TotalSum = x.Sum()
                     };

        return result.ToList();
    }

    public Customer? GetCustomerById(int id)
    {
        using var dbContext = new ApplicationDBContext();
        return dbContext.Customers.Find(id);
    }

    public int AddCustomer(Customer customer)
    {
        using var dbContext = new ApplicationDBContext();
        dbContext.Customers.Add(customer);
        dbContext.SaveChanges();
        return customer.Id;
    }

    public void DeleteCustomer(Customer customer)
    {
        using var dbContext = new ApplicationDBContext();
        dbContext.Customers.Remove(customer);
        dbContext.SaveChanges();
    }

    public void UpdateCustomer(Customer customer)
    {
        using var dbContext = new ApplicationDBContext();
        dbContext.Customers.Update(customer);
        dbContext.SaveChanges();
    }
}
