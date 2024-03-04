using ServiceAccounting.Model.Services.Base;

namespace ServiceAccounting.Model.Services;

public class ProductsService : IProductsService
{
    public void SaveChanges()
    {
        using var dbContext = new ApplicationContext();
        dbContext.SaveChanges();
    }
}

