using Model.Data;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class ProductsService : IProductsService
{
    public IEnumerable<Product> GetProducts()
    {
        using var dbContext = new ApplicationDBContext();
        return dbContext.Products.ToList();
    }

    public int AddProduct(Product product)
    {
        using ApplicationDBContext dbContext = new ApplicationDBContext();
        dbContext.Products.Add(product);
        dbContext.SaveChanges();
        return product.Id;
    }

    public Product? GetProductById(int id)
    {
        using var dbContext = new ApplicationDBContext();
        return dbContext.Products.Find(id);
    }

    public void UpdateProduct(Product product)
    {
        using ApplicationDBContext dbContext = new ApplicationDBContext();
        dbContext.Products.Update(product);
        dbContext.SaveChanges();
    }

    public void RemoveProduct(Product product)
    {
        using var dbContext = new ApplicationDBContext();
        dbContext.Products.Remove(product);
        dbContext.SaveChanges();
    }

    private Product GetProductByIndex(ApplicationDBContext dbContext, int productIndex) => dbContext.Products.FirstOrDefault(p => p.Id == productIndex)
            ?? throw new InvalidOperationException($"Продукта с индексом {productIndex} нет в базе данных.");

}

