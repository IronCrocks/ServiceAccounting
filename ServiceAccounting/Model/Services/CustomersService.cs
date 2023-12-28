using System;
namespace ServiceAccounting.Model.Services;

public class CustomersService : ICustomerService
{
    public CustomersService()
    {

    }

    void GetCustomers()
    {
        using (_dbContext = new ApplicationContext())
        {

            var query = from c in _dbContext.Customers
                        join p in _dbContext.Purchases on c.Id equals p.CustomerId into cs
                        from subPurchases in cs.DefaultIfEmpty()
                        join pr in _dbContext.Products on subPurchases.ProductId equals pr.Id into ps
                        from subProducts in ps.DefaultIfEmpty()
                        group new { c, subPurchases, subProducts } by new { c.Name, c.Age } into g
                        select new
                        {
                            g.Key.Name,
                            g.Key.Age,
                            TotalPrice = g.Sum(x => x.subProducts.Price * x.subPurchases.Count)
                        };
        }
    }
}

