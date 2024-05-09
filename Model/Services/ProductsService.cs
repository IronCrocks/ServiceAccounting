using Model.Data;
using Model.Services.Base;
using ServiceAccounting;

namespace Model.Services;

public class ProductsService : IProductsService
{
    public IEnumerable<object> GetProducts()
    {
        using var dbContext = new ApplicationDBContext();
        return dbContext.Products.ToList();
    }

    public Product AddDefaultProduct()
    {
        var product = new Product();

        using var dbContext = new ApplicationDBContext();
        dbContext.Products.Add(product);
        dbContext.SaveChanges();

        return product;
    }

    public void RemoveProduct(int productIndex)
    {
        using var dbContext = new ApplicationDBContext();
        var removingProduct = GetProductByIndex(dbContext, productIndex);
        dbContext.Products.Remove(removingProduct);
        dbContext.SaveChanges();
    }

    public void SaveChanges()
    {
        using var dbContext = new ApplicationDBContext();
        dbContext.SaveChanges();
    }

    public void ChangeProduct(Product? changedProduct)
    {
        ArgumentNullException.ThrowIfNull(changedProduct);
        using var dbContext = new ApplicationDBContext();

        var selectedProduct = dbContext.Products.Find(changedProduct.Id) ?? throw new InvalidOperationException(
            $"Изменяемый товар с наименованием {changedProduct.Name} не найден в базе данных.");

        selectedProduct.Name = changedProduct.Name;
        selectedProduct.Description = changedProduct.Description;
        selectedProduct.Price = changedProduct.Price;
        dbContext.SaveChanges();
    }

    private Product GetProductByIndex(ApplicationDBContext dbContext, int productIndex) => dbContext.Products.FirstOrDefault(p => p.Id == productIndex)
            ?? throw new InvalidOperationException($"Продукта с индексом {productIndex} нет в базе данных.");

}

