using System.ComponentModel.DataAnnotations;

namespace Model.Entites;

public class Order
{
    public int Id { get; set; }
    [Required]
    public string Number { get; set; } = string.Empty;
    public DateTime Date { get; set; } = DateTime.Now;

    public List<OrderItem> OrderItems { get; set; } = new();

    public Customer? Customer { get; set; }
    public int CustomerId { get; set; }
}
