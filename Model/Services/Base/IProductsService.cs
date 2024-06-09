using Model.Data;

namespace Model.Services.Base;

public interface IProductsService : IService
{
    public IEnumerable<Product> GetProducts();
   
    void AddProduct(Product product);
    Product GetProductById(int id);
    void UpdateProduct(Product product);
    void RemoveProduct(Product product);
}
