namespace Model.Data;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Price { get; set; }

    public List<Order> Orders { get; set; } = new List<Order>();
    public List<OrderItem> OrderItems { get; set; }
}
