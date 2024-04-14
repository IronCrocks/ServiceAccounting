namespace Model.Services.Base;

public interface IProductsService : IService
{
    public IEnumerable<object> Load();
    public void SaveChanges();
}
