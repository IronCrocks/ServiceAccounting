using Model.Entites;

namespace Model.Services.Base;

public interface IProductsService : IService
{
    public IEnumerable<Product> GetProducts();
   
    int AddProduct(Product product);
    Product? GetProductById(int id);
    void UpdateProduct(Product product);
    void RemoveProduct(Product product);
}
