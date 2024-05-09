using Model.Data;

namespace Model.Services.Base;

public interface IProductsService : IService
{
    public IEnumerable<object> GetProducts();
    public Product AddDefaultProduct();
    public void SaveChanges();
    void RemoveProduct(int productIndex);
    void ChangeProduct(Product? changedProduct);
}
