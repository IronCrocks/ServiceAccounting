using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class ProductsService : IProductsService
{
    public IEnumerable<object> Load()
    {
        using var dbContext = new ApplicationContext();
        return dbContext.Products;
    }

    public void SaveChanges()
    {
        using var dbContext = new ApplicationContext();
        dbContext.SaveChanges();
    }
}

